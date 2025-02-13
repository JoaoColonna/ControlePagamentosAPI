# ControlePagamentoAPI

O ControlePagamentoAPI é uma aplicação para gerenciar pagamentos e clientes. A API permite criar e listar pagamentos e clientes, além de atualizar o status dos pagamentos.

## Pré-requisitos
- .NET 8 SDK
- Banco de dados PostgreSQL

## Clonando o Repositório
Clone o repositório para sua máquina local usando o comando:

```
	git clone https://github.com/seu_usuario/ControlePagamentoAPI.git

```

## Configuração do Banco de Dados
1. Configure a string de conexão do banco de dados no arquivo `appsettings.json` localizado na raiz do projeto `ControlePagamentosAPI`:
```
	 "ConnectionStrings": { "SqlConnection": "Host=localhost;Database=postgres;Username=postgres;Password=sua_senha" } }
```

## Instalando Dependências
Navegue até a pasta do projeto e restaure as dependências do .NET:

```
	cd ControlePagamentoAPI
	dotnet restore
```

## Executando Migrações
Aplique as migrações para criar o banco de dados e as tabelas necessárias:

```
	cd Infrasctructure 
	dotnet ef database update
```

## Iniciando a Aplicação
Navegue até a pasta do projeto principal e inicie a aplicação:

```
	cd ControlePagamentosAPI 
	dotnet run
```

A aplicação estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

## Endpoints Disponíveis
### Clientes
- `GET /api/clientes/todos`: Lista todos os clientes.
- `POST /api/clientes`: Cria um novo cliente.
- `GET /api/clientes/{id}`: Obtém um cliente pelo ID.
- `PUT /api/clientes/{id}`: Atualiza um cliente pelo ID.
- `DELETE /api/clientes/{id}`: Deleta um cliente pelo ID.

### Pagamentos
- `GET /api/pagamentos/todos`: Lista todos os pagamentos.
- `POST /api/pagamentos`: Cria um novo pagamento.
- `GET /api/pagamentos?clienteId={clienteId}`: Obtém pagamentos por ID do cliente.
- `PUT /api/pagamentos/{id}/status`: Atualiza o status de um pagamento.

## Configuração de CORS
Para permitir requisições de diferentes origens, o CORS foi configurado no projeto. Você pode ajustar as configurações de CORS no arquivo `Startup.cs` conforme necessário.

## Contribuição
Sinta-se à vontade para contribuir com o projeto. Faça um fork do repositório, crie uma branch para suas alterações e envie um pull request.

## Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---

Com este `README.md`, os desenvolvedores terão um guia claro sobre como configurar, rodar e contribuir para o projeto.