var app = angular.module("app", ['ngMask', 'ngResource', 'datatables']);

app.controller("locatarioController", ($scope, $http, DTOptionsBuilder) => {



    var lang = {
        "sEmptyTable": "Nenhum registro encontrado",
        "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
        "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
        "sInfoFiltered": "(Filtrados de _MAX_ registros)",
        "sInfoPostFix": "",
        "sInfoThousands": ".",
        "sLengthMenu": "_MENU_ resultados por página",
        "sLoadingRecords": "Carregando...",
        "sProcessing": "Processando...",
        "sZeroRecords": "Nenhum registro encontrado",
        "sSearch": "Pesquisar",
        "oPaginate": {
            "sNext": "Próximo",
            "sPrevious": "Anterior",
            "sFirst": "Primeiro",
            "sLast": "Último"
        },
        "oAria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma descendente"
        },
        "select": {
            "rows": {
                "_": "Selecionado %d linhas",
                "0": "Nenhuma linha selecionada",
                "1": "Selecionado 1 linha"
            }
        }
    };


    $scope.dtOptions = DTOptionsBuilder.newOptions()
        .withPaginationType('full_numbers').withDisplayLength(5).withLanguage(lang);

    $scope.tipoLocatario = true;

    $scope.novo = () => {

        Swal.fire({
            title: 'Você é uma empresa ou uma pessoa?',
            type: 'question',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sou uma Empresa',
            cancelButtonText: 'Sou uma Pessoa'
        }).then((result) => {


            if (result) {
                if (result.value) {
                    $scope.resetForm();
                    $("#modalLocatario").modal("show");
                    $("#nome").focus();
                    $scope.tipoLocatario = false;
                }
                else {
                    $scope.resetForm();
                    $("#modalLocatario").modal("show");
                    $("#nome").focus();
                    $scope.tipoLocatario = true;
                }
            }
        })

  
    }

    $scope.remover = (id) => {

        $http.post("Locatario/Remover",id)
            .then((response) => {
                $scope.locatarios = response.data;
                $scope.listaLocatarios();
                Swal.fire(
                    'Sucesso!',
                    'Locatario removido com sucesso!',
                    'success'
                )
            })
            .catch((response) => {
                Swal.fire(
                    'Erro!',
                    'Não foi possível remover este locatario!',
                    'warning'
                )
            })
    }

    $scope.editar = (locatario, form) => {

        $("#modalLocatario").modal("show");
        $scope.locatario = angular.copy(locatario);

        $scope.tipoLocatario = ($scope.locatario.Cpf ? true : false);
        console.log($scope.tipoLocatario)
        $scope.formValidate(form);
    }

    $scope.listaLocatarios = () => {
        $http.get("Locatario/Listar")
            .then((response) => {
                $scope.locatarios = response.data;
            })
            .catch((response) => {
                Swal.fire(
                    'Erro!',
                    'Não foi possível obter a lista de locatarios!',
                    'warning'
                )
            })
    }

    $scope.formValidate = (form) => {

        angular.forEach(form.$$controls, (value) => {
            value.$untouched = true;
            value.$dirty = true;
        });
    };

    $scope.listaLocatarios();

    $scope.resetForm = () => {
        delete $scope.locatario;
        $scope.formLocatario.$setPristine();
        $scope.formLocatario.$setUntouched();
    }

    $scope.salvar = (locatario) => {

        var _locatario = angular.copy(locatario);

        //_locatario.Cpf = _locatario.Cpf.replace(".", "").replace(".", "").replace("-","")
        //_locatario.Telefone = _locatario.Telefone.replace("(", "").replace(")", "").replace("-", "")

        console.log(_locatario);

        if (!_locatario.idLocatario) {
            $http.post("Locatario/Cadastrar", _locatario)
                .then((response) => {
                    $scope.listaLocatarios();
                    $scope.resetForm();
                    $("#modalLocatario").modal("hide");
                    Swal.fire(
                        'Sucesso!',
                        'Locatario criado com sucesso!',
                        'success'
                    )
                })
                .catch((response) => {
                    console.log(response)
                });
        }
        else {
            $http.post("Locatario/Editar", _locatario)
                .then((response) => {
                    $scope.listaLocatarios();
                    $scope.resetForm();
                    $("#modalLocatario").modal("hide");
                    Swal.fire(
                        'Sucesso!',
                        'Locatario alterado com sucesso!',
                        'success'
                    )
                })
                .catch((response) => {
                    console.log(response)
                });
        }
    }

})