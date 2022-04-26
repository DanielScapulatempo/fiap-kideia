# fiap-kideia

## Observação
- Projeto dentro da pasta KideiaWebAPI<br>
- Desenvolvido em C# .Net Core 5<br>
- Consideramos, para efeito de testes, o host localhost:2159.<br>
- Ao efetuar o clone do repositório, substitua pelo seu host na URL.

_________________

## Documentação

> Projeto com swagger habilitado:<br>
> `http://localhost:2159/swagger/index.html`

_________________

## URLs

### ProcessStatus
- Verifica o status do processo, passando como parâmetro o id do usuário<br> ```[GET] http://localhost:2159/ProcessStatus/1```

### User
- Lista todos os usuários<br> ```[GET] http://localhost:2159/User```
- Lista os dados de um usuário, passando como parâmetro o id<br> ```[GET] http://localhost:2159/User/1```
