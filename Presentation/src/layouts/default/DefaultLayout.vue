<script setup lang="ts">
import { HomeIcon, ChartNetwork, HandCoins, Handshake, Calendar } from 'lucide-vue-next';
</script>

<template>
    <div class="hidden w-full md:flex bg-background justify-center items-center py-3">
        Home | Loans | Dashboard | Debts | Calendar
    </div>
    <RouterView />
    <div class="fixed md:hidden w-full bottom-0 p-3">
        <div class="grid grid-cols-5 gap-2 rounded-lg px-2 py-2 w-full border bg-background">
            <RouterLink to="/" class="p-2 flex justify-center items-center flex-col hover:bg-muted rounded-lg">
                <HomeIcon class="size-7" />
                Home
            </RouterLink>
            <RouterLink to="/" class="p-2 flex justify-center items-center flex-col hover:bg-muted rounded-lg">
                <Handshake class="size-7" />
                Loans
            </RouterLink>
            <RouterLink to="/" class="p-2 flex justify-center items-center flex-col hover:bg-muted rounded-lg">
                <ChartNetwork class="size-7" />
                Dashboard
            </RouterLink>
            <RouterLink to="/" class="p-2 flex justify-center items-center flex-col hover:bg-muted ">
                <HandCoins class="size-7" />
                Debts
            </RouterLink>
            <RouterLink to="/" class="p-2 flex justify-center items-center flex-col hover:bg-muted rounded-lg">
                <Calendar class="size-7" />
                Calendar
            </RouterLink>
        </div>
    </div>
</template>