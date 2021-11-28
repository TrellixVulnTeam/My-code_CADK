<template>
  <div id="app">
    <input type="text" placeholder="enter content">
    <button v-on:click= "title= 'This is message'">Click me</button>
    <comp-header v-bind:title = "title" />
    <ul> List user
      <li v-for= "user in listUser" v-bind:key= "user.key">{{user.email}}</li>
    </ul>
    <list-user
    v-bind:listUser= "listUser"
    v-bind:deleteUserEvent = 'handleDeleteUser'
    />
    <comp-footer />
  </div>
</template>

<script>
import CompHeader from './components/componentHeader.vue'
import ListUser from './components/listUser.vue'
import CompFooter from './components/componentFooter.vue'
export default {
  name: 'App',
  data () {
    return {
      title: "I'm Bui Huu Dat",
      listUser: [
        {id: 100, email: 'test1@gmail.com', active: true},
        {id: 101, email: 'test2@gmail.com', active: true},
        {id: 102, email: 'test3@gmail.com', active: false},
        {id: 103, email: 'test4@gmail.com', active: true},
        {id: 104, email: 'test5@gmail.com', active: false},
        {id: 105, email: 'test6@gmail.com', active: true},
        {id: 106, email: 'test7@gmail.com', active: true}
      ]
    }
  },
  methods: {
    handleDeleteUser (data) {
      console.log(data)
    }
  },
  components: {
    CompHeader,
    ListUser,
    CompFooter
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
