<script setup lang="ts">
import { DebtCard } from '@/components';

</script>

<template>
    <div class="p-3">
        <h1 class="text-3xl font-bold mb-4">My Loans</h1>
        <div class="space-y-2">
            <DebtCard v-for="(item, index) in 20" :key="index + 'loan'" />
        </div>
    </div>
</template>