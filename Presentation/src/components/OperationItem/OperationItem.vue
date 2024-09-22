<script setup lang="ts">
defineProps({
    operationType: String,
    item: Object
})
</script>

<template>
    <div class="p-1 flex gap-3">
        <div class="w-[10px] h-[70px]" :class="operationType === 'loan' ? 'bg-emerald-400' : 'bg-red-500'" />
        <div class="self-start">
            <div class="flex justify-start items-start flex-col">
                <h2 class="w-[10px] h-full text-lg font-semibold">{{ operationType === 'loan' ? 'Loan' : 'Debt' }}</h2>
                <p class="text-sm">{{ item?.close_date }}</p>
                <p class="text-sm">{{ item?.status }}</p>
            </div>
        </div>
        <div class="flex justify-end w-full items-end flex-col">
            <h2 class="text-lg">{{ item?.amount }} UZS</h2>
            <p>receiver: {{ item?.counterparty_name }}</p>
            <p>receiver: {{ item?.added_on }}</p>
        </div>
    </div>
</template>