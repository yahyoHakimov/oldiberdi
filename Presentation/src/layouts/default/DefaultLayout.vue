<script setup lang="ts">
import { HomeIcon, HandCoins, Handshake, Ellipsis, UserCircle, LogOut, Calendar, Gem } from 'lucide-vue-next';
import {
    Drawer,
    DrawerClose,
    DrawerContent,
    DrawerFooter,
    DrawerHeader,
    DrawerTitle,
    DrawerTrigger,
} from '@/components/ui/drawer'
import { Button } from '@/components/ui/button';
</script>

<template>
    <!-- <div class="hidden w-full md:flex bg-background justify-center items-center py-3">
        Home | Loans | Dashboard | Debts | Calendar
    </div> -->
    <RouterView />
    <div class="fixed md:hidden w-full bottom-0 p-2">
        <div class="grid grid-cols-8 rounded-lg w-full border bg-background">
            <RouterLink to="/" class="p-2 col-span-2 flex justify-center items-center flex-col hover:bg-muted">
                <HomeIcon class="size-7" />
                Home
            </RouterLink>
            <RouterLink to="loans" class="p-2  col-span-2 flex justify-center items-center flex-col hover:bg-muted">
                <Handshake class="size-7" />
                Loans
            </RouterLink>
            <!-- <RouterLink to="dashboard" class="p-2 col-span-3 flex justify-center items-center flex-col hover:bg-muted">
                <ChartNetwork class="size-7" />
                Overview
            </RouterLink> -->
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
                        <DrawerTitle>More Actions</DrawerTitle>
                    </DrawerHeader>
                    <div class="p-2">
                        <Button variant="ghost" class="w-full justify-start gap-2 text-lg">
                            <UserCircle />
                            <span>
                                Profile
                            </span>
                        </Button>
                        <Button variant="ghost" class="w-full justify-start gap-2 text-lg">
                            <Calendar />
                            <span>
                                Calendar
                            </span>
                        </Button>
                        <Button variant="ghost" class="w-full justify-start gap-2 text-lg">
                            <Gem class="text-cyan-500" />
                            <span>
                                Subscription
                            </span>
                        </Button>
                        <Button variant="ghost" class="w-full justify-start gap-2 text-lg mt-10">
                            <LogOut />
                            <span>
                                Logout
                            </span>
                        </Button>
                    </div>
                    <DrawerFooter>
                        <DrawerClose>
                            <Button variant="outline" class="w-full">
                                Cancel
                            </Button>
                        </DrawerClose>
                    </DrawerFooter>
                </DrawerContent>
            </Drawer>
        </div>
    </div>
</template>