const app = new Vue({
  data: () => ({

    consonantes: [],
    vocales: [],
    newUser: { name: '' }
  }),



  methods: {
    addUser: function () {
      let name = this.newUser.name.trim().toLowerCase();

      if (name ) {

     

        if (name < 6) {
          this.vocales.push({
            name: name
           
          });

        }
        else {
          this.consonantes.push({
            name: name
           
          });
        }
      }
      this.newUser.name = this.newUser.name = '';

      this.vocales = this.OrdenarListas(this.vocales);

      this.consonantes = this.OrdenarListas(this.consonantes);


    },


    OrdenarListas: function (lista) {
      lista = lista.sort(function (a, b) {
        if (a.name > b.name) {
          return 1;
        }
        if (a.name < b.name) {
          return -1;
        }

        return 0;
      });

      return lista;
    },

    OrdenarListas2: function (lista) {
      lista = lista.sort(function (a, b) {
        if (a.name < b.name) {
          return 1;
        }
        if (a.name > b.name) {
          return -1;
        }

        return 0;
      });

      return lista;
    }
  }

}).$mount('#app');






//for (i = 0; i < 10; i++) {

//  var vocal;

//  if (i = 0) {
//    vocal = "a";
//  }
//  else if (i = 1) {
//    vocal = "e";
//  }
//  else if (i = 2) {
//    vocal = "i";
//  }
//  else if (i = 3) {
//    vocal = "o";
//  }
//  else if (i = 4) {
//    vocal = "u";
//  }
//  else if (i = 5) {
//    vocal = "A";
//  }
//  else if (i = 6) {
//    vocal = "E";
//  }
//  else if (i = 7) {
//    vocal = "I";
//  }
//  else if (i = 8) {
//    vocal = "O";
//  }
//  else if (i = 9) {
//    vocal = "U";
//  }

//  var aux = person.indexOf(vocal);

//  if (aux != -1) {
//    numVocales++;
//  }

//}

