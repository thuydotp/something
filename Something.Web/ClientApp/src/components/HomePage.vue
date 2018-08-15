<template>
    <div>        
        <h2>{{pageTitle}}</h2>
        <span v-bind:title="message">Hover your mouse over me for a few seconds to see my dynamically bound title!</span>
        <div v-if="seen">Now you see me</div>
        <ol>
            <li v-for="todo in todos">
            {{ todo.text }}
            </li>
        </ol>
        <button v-on:click="reversePageTitle">Reverse Page Title</button>
        <input v-model="pageTitle">
    </div> 
</template>

<script>
export default {
  name: "HomePage",
  data: function() {
    return {
      pageTitle: "This is homepage",
      message: "You loaded this page on " + new Date().toLocaleString(),
      seen: true,
      todos: [
        { text: "Learn JavaScript" },
        { text: "Learn Vue" },
        { text: "Build something awesome" }
      ]
    };
  },
  methods: {
    reversePageTitle: function () {
      this.pageTitle = this.pageTitle.split('').reverse().join('');
    }
  }
};
</script>
