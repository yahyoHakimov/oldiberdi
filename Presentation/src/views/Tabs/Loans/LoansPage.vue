<script setup lang="ts">
import api from '@/api/axios';
import { LoanCard } from '@/components';
import AddLoan from '@/components/Add/AddLoan.vue';
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
const loans = ref([])

const fetchOperations = async () => {
    try {
        const response = await api.get('/operations', {
            params: {
                user_id: auth.user.id,
                operation_type: 'loan'
            }
        })
        loans.value = response.data
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
            <h1 class="text-3xl font-bold">My Loans</h1>
            <Sheet>
                <SheetTrigger>
                    <Button>Add Loan</Button>
                </SheetTrigger>
                <SheetContent class="w-full md:w-[400px]">
                    <SheetHeader>
                        <SheetTitle>Add Loan</SheetTitle>
                    </SheetHeader>
                    <AddLoan @refetch="refetch" />
                </SheetContent>
            </Sheet>
        </div>
        <div class="space-y-2">
            <!-- <LoanCard v-for="(item, index) in loans" :key="index + 'loan'" :item="item" /> -->
            <LoanCard v-for="(item, index) in loans" :key="index + 'loan'" :item="item" />
        </div>
    </div>
</template>