<script setup lang="ts">
import { Button } from '@/components/ui/button'
import { Input } from '@/components/ui/input'
import { Label } from '@/components/ui/label'
import { useAuthStore } from '@/stores/auth';
import { ref } from 'vue';

const auth = useAuthStore()
const phone = ref('')
const password = ref('')
const firstName = ref('')
const lastName = ref('')

const register = async () => {
    await auth.register(phone.value, password.value, firstName.value, lastName.value)
}
</script>

<template>
    <div class="flex items-center justify-center py-12">
        <div class="mx-auto grid w-[350px] gap-6">
            <div class="grid gap-2 text-center">
                <h1 class="text-3xl font-bold">
                    Registration
                </h1>
                <p class="text-balance text-muted-foreground">
                    Enter your email below to login to your account
                </p>
            </div>
            <div class="grid gap-4">
                <div class="grid gap-2">
                    <Label for="phone">Phone</Label>
                    <Input v-model="phone" id="email" type="email" placeholder="+998 12 123 12 12" required />
                </div>
                <div class="grid gap-2">
                    <Label for="">First Name</Label>
                    <Input v-model="firstName" id="email" type="email" placeholder="John" required />
                </div>
                <div class="grid gap-2">
                    <Label for="">Last Name</Label>
                    <Input v-model="lastName" id="email" type="email" placeholder="Doe" required />
                </div>
                <div class="grid gap-2">
                    <div class="flex items-center">
                        <Label for="password">Password</Label>
                    </div>
                    <Input v-model="password" id="password" type="password" required />
                </div>
                <Button :disabled="phone.length === 0 || password.length === 0 || firstName.length === 0"
                    @click="register" type="submit" class="w-full">
                    Register
                </Button>
            </div>
            <div class="mt-4 text-center text-sm">
                Already have an account?
                <router-link to="login">
                    Sign in
                </router-link>
            </div>
        </div>
    </div>
</template>