<h1> Modelagem-telefonica</h1>
<h3>Objetivo</h3>
<p>Com o intuito de aprender mais sobre orientação a objetos, herança e outros conceitos que abrangem essa área esse projeto é ótimo para isso</p>

<b>A empresa de telefonia "Te Mato Se Estiver Vivo" deseja criar um sistema para atender seu negócio. Para isto, ela expôs o seguinte:</b>

<p>Existem dois tipos de linhas, móveis e fixas. Ambas as linhas possuem nome do titular, numero e ano de contratação. As linhas móveis possuem quantidade atual de saldo, nova mensagem, se possui plano de dados ou não e se o SMS está disponível. As linhas fixas possuem valor da mensalidade, franquia mensal em minutos, valor restante da franquia e se a fatura já foi paga ou não.
As linhas móveis possuem o método "Recarregar", onde é inserido um valor em Reais e este renova o saldo.</p>

<p>Existe um método "Navegar" onde, caso a linha possua direito à plano de dados, é inserido a quantidade de MB desejados. Deverá ser feito o cálculo debitante do saldo. Cada 4MB custa R$ 0.99. Caso não haja direito ao serviço, exibir "Serviço indisponível".
O método "EnviarSMS" recebe como parâmetro uma linha móvel e uma mensagem. Caso a linha solicitante possua direito a SMS, a mensagem será passada à linha destino, debitando-se o valor de um SMS da solicitante, que é R$ 0,10. Caso não possua, exibir "serviço indisponível".

Já as linhas fixas possuem o método "Ligar", onde é passado a quantidade de minutos da ligação e debitado da quantia restante de franquia. Só será possível fazer a ligação caso o valor restante da franquia seja suficiente e a fatura esteja paga.

A linha fixa também possui o método "Pagarfatura" onde serão renovados os limites da linha.</p>

<p>Diante do exposto, você, um bom e dedicado desenvolvedor, fará a modelagem do sistema e sua implementação em C#. Os casos de testes deverão testar todas as funcionalidades. 
Lembre-se de que os construtores devem receber valores iniciais. Atente-se também aos modificadores de acesso.</p>

<h3>Modelagem</h3>
<img src="https://i.imgur.com/q7NEL1S.png"></img>
