const app = new Vue({
  data: () => ({
    aprobados: [],
    desaprobados: [],
    newUser: { name: '', nota: '' },
  }),



  methods: {
    addUser: function () {
      let name = this.newUser.name.trim().toLowerCase();
      let nota = this.newUser.nota.trim().toLowerCase();
      if (name && nota) {

        if (nota < 6) {
          this.desaprobados.push({
            name: name,
            nota: nota
          });

        }
        else {
          this.aprobados.push({
            name: name,
            nota: nota
          });
        }
      }
      this.newUser.name = this.newUser.nota = '';
    }
  }
}).$mount('#app');


// sort 


console.log(name.sort(function (prev, next) {
  if (prev.name > next.name) {
    return 1;
  }
  if (prev.name < next.name) {
    return -1;
  }
  return 0;
  //  return prev.level - next.level;
}))
