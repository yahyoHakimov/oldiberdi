<script setup lang="ts">
import { Card, CardTitle } from '@/components/ui/card'
import { Accordion, AccordionContent, AccordionItem, AccordionTrigger } from '@/components/ui/accordion'

defineProps({
    item: Object
})
</script>

<template>
    <Card>
        <Accordion type="single" collapsible>
            <AccordionItem value="item-1">
                <AccordionTrigger>
                    <div class="flex justify-start items-start flex-col px-3">
                        <CardTitle>Debt</CardTitle>
                    </div>
                </AccordionTrigger>
                <AccordionContent>
                    <div class="p-2 space-y-2">
                        <div class="flex justify-between border-b">
                            <p>Amount</p>
                            <p>{{ item?.amount }} UZS</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Sender</p>
                            <p>{{ item?.counterparty_name }}</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Added on</p>
                            <p>{{ item?.added_on }}</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Close date</p>
                            <p>{{ item?.close_date }}</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Payed amount</p>
                            <p>{{ item?.payed_amount }}</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Payed percent</p>
                            <p>{{ item?.payed_percent }}</p>
                        </div>
                        <div class="flex justify-between  border-b">
                            <p>Status</p>
                            <p>{{ item?.status }}</p>
                        </div>
                    </div>
                </AccordionContent>
            </AccordionItem>
        </Accordion>
    </Card>
</template>