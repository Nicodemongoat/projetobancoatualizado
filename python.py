from datetime import datetime


class Banco:
    def __init__(self, nome, codigo_bacen):
        self.nome = nome
        self.codigo_bacen = codigo_bacen


class ContaBancaria:
    def __init__(self, agencia, numero_conta):
        self.agencia = agencia
        self.numero_conta = numero_conta
        self._saldo = 0.0

    @property
    def saldo(self):
        return self._saldo


class Transacao:
    def __init__(self, valor, tipo, conta_origem, conta_destino):
        self.valor = valor  # vai passar pela validação
        self.data = datetime.now()
        self.tipo = tipo
        self.conta_origem = conta_origem
        self.conta_destino = conta_destino

    @property
    def valor(self):
        return self._valor

    @valor.setter
    def valor(self, value):
        if value <= 0:
            raise ValueError("ERRO: o valor não pode ser negativo ou zero!")
        self._valor = value


# =========================
# PROGRAMA PRINCIPAL
# =========================

meu_banco = Banco("Banco do Brasil", "001")

origem = ContaBancaria("0001", "12345-6")
destino = ContaBancaria("0001", "98765-4")

# Teste com valor válido
minha_transacao = Transacao(
    250.00,
    "PIX",
    origem,
    destino
)

print("--- REGISTRO BACEN ---")
print("Banco:", meu_banco.nome)
print("Código:", meu_banco.codigo_bacen)
print("----------------------")
print("Tipo:", minha_transacao.tipo)
print("Valor: R$", minha_transacao.valor)
print("Data:", minha_transacao.data)
print("Origem:", origem.agencia, "/", origem.numero_conta)
print("Destino:", destino.agencia, "/", destino.numero_conta)