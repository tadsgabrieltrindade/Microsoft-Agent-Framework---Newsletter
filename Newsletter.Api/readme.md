# Camada API

> Essa camada é responsável por expor os endpoints da aplicação, ou seja, as rotas e os controladores que irão receber as requisições dos clientes e retornar as respostas. Ela é dependente da camada Core e da camada de Infraestrutura, mas não deve conter nenhuma lógica de negócio, apenas a orquestração das chamadas às camadas inferiores.