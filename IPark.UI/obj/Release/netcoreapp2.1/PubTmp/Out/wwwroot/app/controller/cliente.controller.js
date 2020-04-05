var app = angular.module("app", ['ngMask', 'ngResource','datatables']);

app.controller("clienteController", ($scope, $http, DTOptionsBuilder) => {



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

    $scope.novo = () => {
        $scope.resetForm();
        $("#modalCliente").modal("show");
        $("#nome").focus();
    }

    $scope.remover = (id) => {

        console.log(id)

        $http.post("Cliente/Remover",id)
            .then((response) => {
                $scope.clientes = response.data;
                $scope.listaClientes();
                Swal.fire(
                    'Sucesso!',
                    'Cliente removido com sucesso!',
                    'success'
                )
            })
            .catch((response) => {
                Swal.fire(
                    'Erro!',
                    'Não foi possível remover este cliente!',
                    'warning'
                )
            })
    }

    $scope.editar = (cliente,form) => {
        $("#modalCliente").modal("show");
        $scope.cliente = angular.copy(cliente);
        $scope.formValidate(form);
    }

    $scope.formValidate = (form) => {

        angular.forEach(form.$$controls, (value) => {
            value.$untouched = true;
            value.$dirty = true;
        });
    };

    $scope.listaClientes = () => {
        $http.get("Cliente/Listar")
            .then((response) => {
                $scope.clientes = response.data;
            })
            .catch((response) => {
                Swal.fire(
                    'Erro!',
                    'Não foi possível obter a lista de clientes!',
                    'warning'
                )
            })
    }

    $scope.listaClientes();

    $scope.resetForm = () => {
        delete $scope.cliente;
        $scope.formCliente.$setPristine();
        $scope.formCliente.$setUntouched();
    }

    $scope.salvar = (cliente) => {

        var _cliente = angular.copy(cliente);

        _cliente.Cpf = _cliente.Cpf.replace(".", "").replace(".", "").replace("-","")
        _cliente.Telefone = _cliente.Telefone.replace("(", "").replace(")", "").replace("-", "")

        console.log(_cliente);

        if (!_cliente.idCliente) {
            $http.post("Cliente/Cadastrar", _cliente)
                .then((response) => {
                    $scope.listaClientes();
                    $scope.resetForm();
                    $("#modalCliente").modal("hide");
                    Swal.fire(
                        'Sucesso!',
                        'Cliente criado com sucesso!',
                        'success'
                    )
                })
                .catch((response) => {
                    console.log(response)
                });
        }
        else {
            $http.post("Cliente/Editar", _cliente)
                .then((response) => {
                    $scope.listaClientes();
                    $scope.resetForm();
                    $("#modalCliente").modal("hide");
                    Swal.fire(
                        'Sucesso!',
                        'Cliente alterado com sucesso!',
                        'success'
                    )
                })
                .catch((response) => {
                    console.log(response)
                });
        }
    }

})