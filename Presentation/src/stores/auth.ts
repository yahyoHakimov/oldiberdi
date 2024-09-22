import { ref, computed } from 'vue'
import { defineStore } from 'pinia'
import api from '@/api/axios'

export const useAuthStore = defineStore('auth', () => {
  const user = ref<{
    id: number
    phone: number
    password: string
    first_name: string
    last_name?: string
    patronimic?: string
    email?: string
    pinfl?: number
    dob?: Date
    passport_num?: string
    passport_type?: number
    country_?: number
    region_?: number
    district_?: number
    address?: string
    liveness_passed: boolean
    identified: boolean
    status: 'new' | 'phone_verified' | 'id_verified'
    sub_plan_?: number
    sub_expire_date?: Date
    added_on?: Date
    updated_on?: Date
    token: string
  }>({
    id: 0,
    phone: 0,
    password: '',
    first_name: '',
    liveness_passed: false,
    identified: false,
    status: 'new',
    token: ''
  })

  async function login(phone: string, password: string) {
    try {
      const { data } = await api.post('/user/login', { Phone: phone, Password: password })
      // return response
      user.value = data
    } catch (e) {
      console.error(e)
    }
  }

  async function register(phone: string, firstName: string, lastName: string, password: string) {
    try {
      const { data } = await api.post('/user/register', {
        Phone: phone,
        FirstName: firstName,
        LastName: lastName,
        Password: password
      })
      // return response
      user.value = data
    } catch (e) {
      console.error(e)
    }
  }

  const isAuth = computed(() => {
    return user.value.token ? true : false
  })

  return { login, user, isAuth, register }
})
