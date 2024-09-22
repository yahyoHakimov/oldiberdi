<script lang="ts" setup>
import { Avatar, AvatarFallback, AvatarImage } from '@/components/ui/avatar'
import {
    Sheet,
    SheetContent,
    SheetHeader,
    SheetTitle,
    SheetTrigger,
} from '@/components/ui/sheet'
import {
    Card,
    CardContent,
    CardDescription,
    CardFooter,
    CardHeader,
    CardTitle,
} from '@/components/ui/card'
import { Button } from '@/components/ui/button'
import { useRouter } from 'vue-router';
import { useAuthStore } from '@/stores/auth';
import api from '@/api/axios'
import { ref } from 'vue';
import AddLoan from '@/components/Add/AddLoan.vue';
import AddDebt from '@/components/Add/AddDebt.vue';

const router = useRouter()
const auth = useAuthStore()

const debts = ref([])
const loans = ref([])
const transactions = ref([])

const getDebts = async () => {
    try {
        const response = await api.get('/operations', {
            params: {
                user_id: auth.user.id
            }
        })
        debts.value = response.data
    } catch (error) {
        console.log(error)
    }
}

const getLoans = async () => {
    try {
        const response = await api.get('/operations', {
            params: {
                user_id: auth.user.id
            }
        })
        loans.value = response.data
    } catch (error) {
        console.log(error)
    }
}

const getTransactions = async () => {
    try {
        const response = await api.get('/getTransactions', {
            params: {
                user_id: auth.user.id
            }
        })
        transactions.value = response.data
    } catch (error) {
        console.log(error)
    }
}

const refetch = () => {
    getDebts()
    getLoans()
    getTransactions()
}
</script>


<template>
    <div class="p-3">
        <div class="flex justify-between items-center p-3">
            <div>
                <h1 class="text-3xl font-bold">Welcome, {{ auth.user.first_name }}</h1>
                <p class="text-lg">Check your recent activities</p>
            </div>
            <Avatar>
                <AvatarImage src="https://github.com/radix-vue.png" alt="@radix-vue" />
                <AvatarFallback>CN</AvatarFallback>
            </Avatar>
        </div>
        <div class="flex justify-between items-center gap-2 mt-4">
            <RouterLink to="loans" class="w-full">
                <Card>
                    <CardHeader class="p-3">
                        <CardTitle class="text-xl">Total Loans</CardTitle>
                    </CardHeader>
                    <CardContent class="p-3 text-right text-lg font-semibold text-green-500">4 000 000 UZS
                    </CardContent>

                </Card>
            </RouterLink>
            <RouterLink to="debts" class="w-full">
                <Card>
                    <CardHeader class="p-3">
                        <CardTitle CardTitle class="text-xl">Total Debts</CardTitle>
                    </CardHeader>
                    <CardContent class="p-3 text-right text-lg font-semibold text-red-500">3 000 000 UZS
                    </CardContent>
                </Card>
            </RouterLink>
        </div>
        <div class="grid md:grid-cols-2 gap-3 mt-5">
            <Card @click="router.push('loans')">
                <CardHeader class="flex justify-between items-center flex-row">
                    <CardTitle>Loans</CardTitle>
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
                </CardHeader>
                <CardContent>
                    Card Content
                </CardContent>
                <CardFooter>
                    Card Footer
                </CardFooter>
            </Card>
            <Card @click="router.push('debts')">
                <CardHeader class="flex justify-between items-center flex-row">
                    <CardTitle>Debts</CardTitle>
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
                </CardHeader>
                <CardContent>
                    Card Content
                </CardContent>
                <CardFooter>
                    Card Footer
                </CardFooter>
            </Card>
            <Card class="md:col-span-2">
                <CardHeader>
                    <CardTitle>Transactions</CardTitle>
                    <CardDescription>Card Description</CardDescription>
                </CardHeader>
                <CardContent>
                    Card Content
                </CardContent>
                <CardFooter>
                    Card Footer
                </CardFooter>
            </Card>
        </div>
        <div class="h-[10vh]"></div>
    </div>
</template>