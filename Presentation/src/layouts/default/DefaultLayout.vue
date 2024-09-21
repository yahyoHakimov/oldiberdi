<script setup lang="ts">
import { HomeIcon, ChartNetwork, HandCoins, Handshake, Ellipsis } from 'lucide-vue-next';
import {
    Drawer,
    DrawerClose,
    DrawerContent,
    DrawerDescription,
    DrawerFooter,
    DrawerHeader,
    DrawerTitle,
    DrawerTrigger,
} from '@/components/ui/drawer'
</script>

<template>
    <div class="hidden w-full md:flex bg-background justify-center items-center py-3">
        Home | Loans | Dashboard | Debts | Calendar
    </div>
    <RouterView />
    <div class="fixed md:hidden w-full bottom-0 p-2">
        <div class="grid grid-cols-11 rounded-lg w-full border bg-background">
            <RouterLink to="/" class="p-2 col-span-2 flex justify-center items-center flex-col hover:bg-muted">
                <HomeIcon class="size-7" />
                Home
            </RouterLink>
            <RouterLink to="loans" class="p-2  col-span-2 flex justify-center items-center flex-col hover:bg-muted">
                <Handshake class="size-7" />
                Loans
            </RouterLink>
            <RouterLink to="dashboard" class="p-2 col-span-3 flex justify-center items-center flex-col hover:bg-muted">
                <ChartNetwork class="size-7" />
                Overview
            </RouterLink>
            <RouterLink to="debts" class="p-2  col-span-2 flex justify-center items-center flex-col hover:bg-muted ">
                <HandCoins class="size-7" />
                Debts
            </RouterLink>
            <Drawer>
                <DrawerTrigger class="p-2  col-span-2 flex justify-center items-center flex-col hover:bg-muted">
                    <Ellipsis class="size-7" />
                    More
                </DrawerTrigger>
                <DrawerContent>
                    <DrawerHeader>
                        <DrawerTitle>Are you absolutely sure?</DrawerTitle>
                        <DrawerDescription>This action cannot be undone.</DrawerDescription>
                    </DrawerHeader>
                    <DrawerFooter>
                        <Button>Submit</Button>
                        <DrawerClose>
                            <Button variant="outline">
                                Cancel
                            </Button>
                        </DrawerClose>
                    </DrawerFooter>
                </DrawerContent>
            </Drawer>
        </div>
    </div>
</template>