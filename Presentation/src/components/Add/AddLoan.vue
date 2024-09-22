<script setup lang="ts">
import { useAuthStore } from '@/stores/auth';
import api from '@/api/axios';
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import { Input } from '@/components/ui/input';
import { Button } from '@/components/ui/button';
import { Calendar } from '../ui/calendar';
import { Card, CardContent, CardHeader } from '../ui/card';

type addOperationType = {
    "user_id": number,
    "type": 'loan' | 'debt',
    "amount": number,
    "deal_type": "soft",
    "return_type": "full",
    "close_date": string,
    "counterparty_phone": string,
    "counterparty_name": string,
    "confirmation_needed": true

}

const user = useAuthStore().user
const router = useRouter()
const amount = ref<number>(0)
const phone = ref<string>('')
const name = ref<string>('')

const date = ref<any>(undefined)


const addOperation = async () => {
    try {
        const response = await api.post('/addOperation', {
            user_id: user.id,
            type: 'loan',
            amount: amount.value,
            deal_type: 'soft',
            return_type: 'full',
            close_date: date.value?.toString(),
            counterparty_phone: phone.value,
            counterparty_name: name.value,
            confirmation_needed: true
        } as addOperationType)

        console.log(response)
        if (response.status === 200) {
            router.push('/loans')
        }
    } catch (error) {
        console.log(error)
    }
}
</script>

<template>
    <div class="space-y-2 grid">
        <div class="flex justify-between">
            <div>
                Operation type:
            </div>
            <div>
                Loan
            </div>
        </div>
        <Input v-model="amount" type="number" placeholder="Amount" />
        <div class="flex justify-between">
            <div>
                Deal type:
            </div>
            <div>
                Soft
            </div>
        </div>
        <div class="flex justify-between">
            <div>
                Return amount:
            </div>
            <div>
                Full
            </div>
        </div>
        <Card class="flex justify-center items-centter flex-col">
            <CardHeader>
                Chose closing date:
            </CardHeader>
            <CardContent>

                <Calendar v-model="date" />
            </CardContent>
        </Card>
        <Input v-model="phone" type="text" placeholder="Phone" />
        <Input v-model="name" type="text" placeholder="Name" />
        <Button @click="addOperation">Add</Button>
    </div>
</template>