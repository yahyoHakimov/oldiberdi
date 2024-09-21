<script lang="ts" setup>
import { Avatar, AvatarFallback, AvatarImage } from '@/components/ui/avatar'
import {
    Card,
    CardContent,
    CardDescription,
    CardFooter,
    CardHeader,
    CardTitle,
} from '@/components/ui/card'
</script>


<template>
    <div class="p-3">
        <div class="flex justify-between items-center p-3">
            <div>
                <h1 class="text-3xl font-bold">Welcome, {USER}</h1>
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
            <Card>
                <CardHeader>
                    <CardTitle>Loans</CardTitle>
                    <CardDescription>Card Description</CardDescription>
                </CardHeader>
                <CardContent>
                    Card Content
                </CardContent>
                <CardFooter>
                    Card Footer
                </CardFooter>
            </Card>
            <Card>
                <CardHeader>
                    <CardTitle>Debts</CardTitle>
                    <CardDescription>Card Description</CardDescription>
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