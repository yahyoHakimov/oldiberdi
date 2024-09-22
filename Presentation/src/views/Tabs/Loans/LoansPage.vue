<script setup lang="ts">
import { LoanCard } from '@/components';
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
            <h1 class="text-3xl font-bold">My Loans</h1>
            <Sheet>
                <SheetTrigger>
                    <Button>Add Loan</Button>
                </SheetTrigger>
                <SheetContent class="w-full md:w-[400px]">
                    <SheetHeader>
                        <SheetTitle>Are you absolutely sure?</SheetTitle>
                        <SheetDescription>
                            This action cannot be undone. This will permanently delete your account
                            and remove your data from our servers.
                        </SheetDescription>
                    </SheetHeader>
                </SheetContent>
            </Sheet>
        </div>
        <div class="space-y-2">
            <LoanCard v-for="(item, index) in 20" :key="index + 'loan'" />
        </div>
    </div>
</template>