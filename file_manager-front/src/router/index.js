import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'Main',
        component: () => import('@/views/Main.vue'),
    },
    {
        path: '/Login',
        name: 'Login',
        component: () => import('@/views/Login.vue'),
    },
    {
        path: '/SignUp',
        name: 'SignUp',
        component: () => import('@/views/SignUp.vue'),
    },
]
    
const router = new VueRouter({
    mode: 'history',
    routes,
})

export default router;