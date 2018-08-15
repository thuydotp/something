<template>
    <div>{{todo.text}}</div>
</template>

<script>
export default {
    name: 'todo-item',
    props: ['todo'],
}
</script>

