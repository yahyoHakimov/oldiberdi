import { createRouter, createWebHistory } from 'vue-router'
import { Routes } from './routes'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: Routes
})

router.beforeEach((to, from, next) => {
  const isAuthenticated = !!localStorage.getItem('authToken')

  if (to.meta.requiresAuth && !isAuthenticated) {
    next({ path: '/login' })
  } else {
    next()
  }
})

export default router
