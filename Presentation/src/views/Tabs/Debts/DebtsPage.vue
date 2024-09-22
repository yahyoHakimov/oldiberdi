<script setup lang="ts">
import { DebtCard } from '@/components';
import AddDebt from '@/components/Add/AddDebt.vue';
import { Button } from '@/components/ui/button';
import {
    Sheet,
    SheetContent,
    SheetDescription,
    SheetHeader,
    SheetTitle,
    SheetTrigger,
} from '@/components/ui/sheet'
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
                    <AddDebt />
                </SheetContent>
            </Sheet>
        </div>
        <div class="space-y-2">
            <DebtCard v-for="(item, index) in 20" :key="index + 'loan'" />
        </div>
    </div>
</template>