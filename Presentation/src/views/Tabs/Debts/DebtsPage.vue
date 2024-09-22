<script setup lang="ts">
import api from '@/api/axios';
import { DebtCard } from '@/components';
import AddDebt from '@/components/Add/AddDebt.vue';
import { Button } from '@/components/ui/button';
import {
    Sheet,
    SheetContent,

    SheetHeader,
    SheetTitle,
    SheetTrigger,
} from '@/components/ui/sheet'
import { useAuthStore } from '@/stores/auth';
import { onMounted, ref } from 'vue';

const refetch = () => {
    console.log('refetch')
}
const auth = useAuthStore()
const debts = ref([])

const fetchOperations = async () => {
    try {
        const response = await api.get('/operations', {
            params: {
                user_id: auth.user.id,
                operation_type: 'debt'
            }
        })
        debts.value = response.data
    } catch (error) {
        console.log(error)
    }
}

onMounted(() => {
    fetchOperations()
})
</script>

<template>
    <div class="p-3">
        <div class="flex justify-between items-center  mb-4">
            <h1 class="text-3xl font-bold">My Debts</h1>

            <Sheet>
                <SheetTrigger>
                    <Button>Add Debt</Button>
                </SheetTrigger>
                <SheetContent class="w-full md:w-[400px]">
                    <SheetHeader>
                        <SheetTitle>Add debt</SheetTitle>
                    </SheetHeader>
                    <AddDebt @refetch="refetch" />
                </SheetContent>
            </Sheet>
        </div>
        <div class="space-y-2">
            <DebtCard v-for="(item, index) in debts" :key="index + 'loan'" :item="item" />
        </div>
    </div>
</template>