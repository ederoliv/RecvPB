# RecvPB 
## Software desenvolvido em .NET Framework (C# Windows Forms e Access database), co objetivo que suprir uma necessidade espec�fica no recebimento do almoxarifado central da empresa Prog�s Braesi.

No recebimento de alguns produtos (motores, chicotes el�tricos etc) h� a necessidade de um controle dos produtos que entram, para fins de auditoria,
de modo que em caso de defeito em algum lote dos produtos, seja poss�vel identificar a data de entrada do lote, o fornecedor e quantos itens desde
lote defeituoso h� nas depend�ncias da empresa.

A solu��o at� a data da implanta��o do software � um formul�rio criado com o InfoPath (Microsoft Office 2007), que realiza a persist�ncia dos
dados em um arquivo de banco de dados Access (.accdb). Por se tratar de uma ferramenta antiga, o uso da ferramenta impossibilitou a atualiza��o
do sistema operacional para a vers�o mais recente(Windows 7 PRO para Windows 11 PRO). Para tornar facilitar a migra��o que j� teria como
desafio a mudan�a da interface gr�fica, optei por utilizar o mesmo arquivo de banco de dados, n�o sendo feita a atualiza��o do banco.


No sistema n�s temos que pontuar algumas entidades que s�o fundamentais para que seja feita o controle de entrada de produtos, s�o elas:
- [x] Produto 
- [x] Recebedor
- [x] Fornecedor
- [x] Recebimento

### 1 - Tela inicial/Registro de entrada de produtos
![tela-inicial](/Resources/screenshots/tela-inicial.png)

### 2 - Tela de consulta de recebimentos
![consulta-recebimento](/Resources/screenshots/consulta-recebimento.png)

### 3 - Tela de cadastro de fonecedores
![cadastra-fornecedor](/Resources/screenshots/cadastra-fornecedor.png)

### 4 - Tela de cadastro de recebedores
![cadastra-recebedor](/Resources/screenshots/cadastra-recebedor.png)

### 5 - Tela de cadastro de produtos
![cadastra-produto](/Resources/screenshots/cadastra-produto.png)