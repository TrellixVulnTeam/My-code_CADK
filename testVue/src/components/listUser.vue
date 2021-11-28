<template>
  <div class="list-user">
    <!-- <p>List User Component</p> -->
    <user
    v-for= "user in listUser"
    v-bind:key= "user.id"
    v-bind:user= "user"
    v-on:deleteUser= "deleteUser"
    />
  </div>
</template>

<script>
import User from './user.vue'
export default {
  name: 'list-user',
  props: {
    listUser: {
      type: Array,
      define: []
    }
  },
  methods: {
    deleteUser (data) {
      var indexDelete = -1
      this.listUser.forEach((e, i) => {
        if (e.id === data.id) {
          indexDelete = i
        }
      })
      if (indexDelete !== -1) {
        this.listUser.splice(indexDelete, 1)
      }
      this.$emit('handleDeleteUser', data)
    }
  },
  data () {
    return {

    }
  },
  components: {
    User
  }
}
</script>

<style>
.list-user {
  display: flex;
  gap: 2rem;
  flex-wrap: wrap;
}
.user {
  border: 1px solid black;
  padding: 15px 20px;
}
</style>
