<script setup lang="ts">
import { Card, CardDescription, CardTitle } from '@/components/ui/card'
import { Accordion, AccordionContent, AccordionItem, AccordionTrigger } from '@/components/ui/accordion'
</script>

<template>
    <Card>
        <Accordion type="single" collapsible>
            <AccordionItem value="item-1">
                <AccordionTrigger>
                    <div class="flex justify-start items-start flex-col px-3">
                        <CardTitle>Loan</CardTitle>
                        <CardDescription>Card Description</CardDescription>
                    </div>
                </AccordionTrigger>
                <AccordionContent>
                    Yes. It adheres to the WAI-ARIA design pattern.
                </AccordionContent>
            </AccordionItem>
        </Accordion>
    </Card>
</template>