<script setup lang="ts">
</script>

<template>
    <div class="w-full lg:grid lg:min-h-[600px] lg:grid-cols-2 xl:min-h-[800px]">
        <RouterView />
        <div class="hidden bg-muted lg:block">
            <div
                class="w-screen animated-background h-screen bg-gradient-to-r from-emerald-500 via-blue-500 to-indigo-200">
            </div>
        </div>
    </div>
</template>