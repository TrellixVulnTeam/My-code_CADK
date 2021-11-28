<template>
  <div class="user">
    <p>{{user.email}}</p>
     <button v-on:click= "handleDelete()">Delete</button>
  </div>
</template>

<script>
export default {
  name: 'user',
  props: {
    user: {
      type: Object,
      define: null
    }
  },
  methods: {
    handleDelete (e) {
      var data = {
        id: this.user.id
      }
      this.$emit('deleteUser', data)
    }
  },
  data () {
    return {

    }
  }
}
</script>
