<template>
  <div id="app">
    <HomePage/>
    <ol>
      <todo-item v-for="item in groceryList"
      v-bind:todo="item"
      v-bind:key="item.id"></todo-item>
    </ol>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld";
import HomePage from "./components/HomePage";
import TodoItem from "./components/TodoItem";
export default {
  name: "App",
  components: {
    HelloWorld,
    HomePage,
    TodoItem
  },
  data: function() {
    return {
      groceryList: [
        { id: 0, text: "Vegetables" },
        { id: 1, text: "Cheese" },
        { id: 2, text: "Whatever else humans are supposed to eat" }
      ]
    };
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
