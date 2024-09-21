<script setup lang="ts">
import { DebtCard } from '@/components';
import { Button } from '@/components/ui/button';
</script>

<template>
    <div class="p-3">
        <div class="flex justify-between items-center  mb-4">
            <h1 class="text-3xl font-bold">My Debts</h1>
            <Button>Add loan</Button>
        </div>
        <div class="space-y-2">
            <DebtCard v-for="(item, index) in 20" :key="index + 'loan'" />
        </div>
    </div>
</template>