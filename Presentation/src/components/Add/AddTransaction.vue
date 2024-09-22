<script setup lang="ts">
import api from '@/api/axios';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import { ref } from 'vue';

const amount = ref(0);

const date = ref<any>(undefined);
const type = ref<'cash' | 'card'>('cash');

const submit = async () => {
    try {
        const response = await api.post('/addTransaction', {
            amount: amount.value,
            date: date.value.toString(),
            type: type.value
        })
        if (response.status === 200) {
            console.log(response)
        }
    } catch (error) {
        console.log(error)
    }
}
</script>

<template>
    <div>
        <form @submit="submit">
            <div class="mb-3">
                <Label for="amount" class="form-label">Amount</Label>
                <Input type="number" class="form-control" id="amount" v-model="amount" />
            </div>
            <div class="mb-3">
                <Calendar v-model="date" />
            </div>
            <div class="mb-3">
                <Label for="type" class="form-label">Type</Label>
                <select class="form-select" id="type" v-model="type">
                    <option value="income">Cash</option>
                    <option value="expense">Card</option>
                </select>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</template>