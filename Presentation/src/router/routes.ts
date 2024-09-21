import { DefaultLayout } from '@/layouts'
import HomeView from '../views/Tabs/Home/HomeView.vue'
import AuthLayout from '@/layouts/auth/AuthLayout.vue'
import { LoginPage, RegistrationPage } from '@/views'

export const Routes = [
  {
    path: '/',
    component: DefaultLayout,
    children: [
      {
        path: '',
        name: 'home',
        component: HomeView
      }
    ]
    // meta: {
    //   requiresAuth: true
    // }
  },
  {
    path: '/auth',
    name: 'auth',
    component: AuthLayout,
    children: [
      {
        path: '/login',
        name: 'login',
        component: LoginPage
      },
      {
        path: '/register',
        name: 'register',
        component: RegistrationPage
      }
    ]
  }
]
