# ControlePagamentoAPI

O ControlePagamentoAPI � uma aplica��o para gerenciar pagamentos e clientes. A API permite criar e listar pagamentos e clientes, al�m de atualizar o status dos pagamentos.

## Pr�-requisitos
- .NET 8 SDK
- Banco de dados PostgreSQL

## Clonando o Reposit�rio
Clone o reposit�rio para sua m�quina local usando o comando:

```
	git clone https://github.com/seu_usuario/ControlePagamentoAPI.git

```

## Configura��o do Banco de Dados
1. Configure a string de conex�o do banco de dados no arquivo `appsettings.json` localizado na raiz do projeto `ControlePagamentosAPI`:
```
	 "ConnectionStrings": { "SqlConnection": "Host=localhost;Database=postgres;Username=postgres;Password=sua_senha" } }
```

## Instalando Depend�ncias
Navegue at� a pasta do projeto e restaure as depend�ncias do .NET:

```
	cd ControlePagamentoAPI
	dotnet restore
```

## Executando Migra��es
Aplique as migra��es para criar o banco de dados e as tabelas necess�rias:

```
	cd Infrasctructure 
	dotnet ef database update
```

## Iniciando a Aplica��o
Navegue at� a pasta do projeto principal e inicie a aplica��o:

```
	cd ControlePagamentosAPI 
	dotnet run
```

A aplica��o estar� dispon�vel em `https://localhost:5001` ou `http://localhost:5000`.

## Endpoints Dispon�veis
### Clientes
- `GET /api/clientes/todos`: Lista todos os clientes.
- `POST /api/clientes`: Cria um novo cliente.
- `GET /api/clientes/{id}`: Obt�m um cliente pelo ID.
- `PUT /api/clientes/{id}`: Atualiza um cliente pelo ID.
- `DELETE /api/clientes/{id}`: Deleta um cliente pelo ID.

### Pagamentos
- `GET /api/pagamentos/todos`: Lista todos os pagamentos.
- `POST /api/pagamentos`: Cria um novo pagamento.
- `GET /api/pagamentos?clienteId={clienteId}`: Obt�m pagamentos por ID do cliente.
- `PUT /api/pagamentos/{id}/status`: Atualiza o status de um pagamento.

## Configura��o de CORS
Para permitir requisi��es de diferentes origens, o CORS foi configurado no projeto. Voc� pode ajustar as configura��es de CORS no arquivo `Startup.cs` conforme necess�rio.

## Contribui��o
Sinta-se � vontade para contribuir com o projeto. Fa�a um fork do reposit�rio, crie uma branch para suas altera��es e envie um pull request.

## Licen�a
Este projeto est� licenciado sob a licen�a MIT. Veja o arquivo `LICENSE` para mais detalhes.

---

Com este `README.md`, os desenvolvedores ter�o um guia claro sobre como configurar, rodar e contribuir para o projeto.