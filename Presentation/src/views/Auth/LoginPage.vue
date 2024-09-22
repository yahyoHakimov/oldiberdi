<script setup lang="ts">
import { Button } from '@/components/ui/button'
import { Input } from '@/components/ui/input'
import { Label } from '@/components/ui/label'
import { useAuthStore } from '@/stores/auth';
import { ref } from 'vue';

const phone = ref('')
const password = ref('')

const auth = useAuthStore()

</script>

<template>
    <div class="flex items-center justify-center py-12">
        <div class="mx-auto grid w-[350px] gap-6">
            <div class="grid gap-2 text-center">
                <h1 class="text-3xl font-bold">
                    Login
                </h1>
                <p class="text-balance text-muted-foreground">
                    Enter your email below to login to your account
                </p>
            </div>
            <div class="grid gap-4">
                <div class="grid gap-2">
                    <Label for="email">Phone</Label>
                    <Input v-model="phone" id="phone" type="phone" placeholder="000 00 00" required />
                </div>
                <div class="grid gap-2">
                    <div class="flex items-center">
                        <Label for="password">Password</Label>
                        <a href="/forgot-password" class="ml-auto inline-block text-sm underline">
                            Forgot your password?
                        </a>
                    </div>
                    <Input v-model="password" id="password" type="password" required />
                </div>
                <Button @click="auth.login(phone, password)" type="submit" class="w-full">
                    Login
                </Button>
                <!-- <Button variant="outline" class="w-full">
                    Login with Google
                </Button> -->
            </div>
            <div class="mt-4 text-center text-sm">
                Don't have an account?
                <router-link to="register">
                    Sign up
                </router-link>
            </div>
        </div>
    </div>
</template>