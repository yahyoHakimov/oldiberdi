import { DefaultLayout } from '@/layouts'
import HomeView from '../views/Tabs/Home/HomeView.vue'
import AuthLayout from '@/layouts/auth/AuthLayout.vue'
import { LoginPage, RegistrationPage } from '@/views'
import { DashboardPage, DebtsPage, LoansPage } from '@/views/Tabs'
import CalendarPage from '@/views/Tabs/Calendar/CalendarPage.vue'

export const Routes = [
  {
    path: '/',
    component: DefaultLayout,
    children: [
      {
        path: '',
        name: 'home',
        component: HomeView
      },
      {
        path: '/loans',
        name: 'loans',
        component: LoansPage
      },
      {
        path: '/debts',
        name: 'debts',
        component: DebtsPage
      },
      {
        path: '/dashboard',
        name: 'dashboard',
        component: DashboardPage
      },
      {
        path: '/calendar',
        name: 'calendar',
        component: CalendarPage
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
