const app = new Vue({
  data: () => ({
    consonantes: [],
    vocales: [],
    vocalesAscendentes: [],
    vocalesDescendentes: [],
    consonantesAscendentes: [],
    consonantesDescendentes: [],
    vocalesReversa: [],
    consonantesReversa: [],
    newUser: "",
    names: [
   
    ]
  }),
  methods: {
    addUser: function () {
      let name = this.newUser.trim().toLowerCase();

      this.names.push(name);

      if (name.charAt(0).toUpperCase() === "A" ||
        name.charAt(0).toUpperCase() === "E" ||
        name.charAt(0).toUpperCase() === "I" ||
        name.charAt(0).toUpperCase() === "O" ||
        name.charAt(0).toUpperCase() === "U") {

        this.vocales.push(name);
        var listaVocalesAscendenteAux = [];
        var listaVocalesDescendenteAux = [];
        this.vocalesReversa.push(reverse(name));
        this.consonantesReversa.push(reverse(name));

        for (var i = 0; i < this.vocales.length; i++) {
          listaVocalesAscendenteAux.push(this.vocales[i]);
          listaVocalesDescendenteAux.push(this.vocales[i]);
          

        }
        this.vocalesAscendentes = this.OrdenarListasAsedente(listaVocalesAscendenteAux);
        this.vocalesDescendentes = this.OrdenarListasDesendente(listaVocalesDescendenteAux);

      } else {

        this.consonantes.push(name);

        var listaConsonantesAscendenteAux = [];
        var listaConsonantesDescendenteAux = [];

        for (var j = 0; j < this.consonantes.length; j++) {
          listaConsonantesAscendenteAux.push(this.consonantes[j]);
          listaConsonantesDescendenteAux.push(this.consonantes[j]);
        }
        this.consonantesAscendentes = this.OrdenarListasAsedente(listaConsonantesAscendenteAux);
        this.consonantesDescendentes = this.OrdenarListasDesendente(listaConsonantesDescendenteAux);
      }

      

    },


    OrdenarListasAsedente: function (lista) {
      lista = lista.sort(function (a, b) {
        if (a > b) {
          return 1;
        }
        if (a < b) {
          return -1;
        }
        return 0;
      });
      return lista;
    },

    OrdenarListasDesendente: function (lista) {
      lista = lista.sort(function (a, b) {
        if (a < b) {
          return 1;
        }
        if (a > b) {
          return -1;
        }
        return 0;
      });
      return lista;
    }
  }
}).$mount('#app');


function reverse(s) {
  var o = '';
  for (var l = s.length - 1; l >= 0; l--)
    o += s[l];
  return o;
}
