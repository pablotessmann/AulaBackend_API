-- Criação da tabela: Frutas
CREATE TABLE Fruta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    cor VARCHAR(30),
    preco DECIMAL(10,2)
);

INSERT INTO Fruta (nome, cor, preco)
VALUES ('Maçã', 'Vermelha', 5.50);

SELECT id, nome, cor, preco
FROM abcdef_aula.Fruta;

-- Criação da tabela: Clientes
CREATE TABLE Clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    telefone VARCHAR(20),
    cpf VARCHAR(14) UNIQUE,
    endereco VARCHAR(200),
    cidade VARCHAR(100),
    estado CHAR(2)
);

-- Criação da tabela: Produtos
CREATE TABLE Produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(150) NOT NULL,
    descricao TEXT,
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL DEFAULT 0,
    ativo BOOLEAN NOT NULL DEFAULT TRUE
);

-- Criação da tabela: Pedidos
CREATE TABLE Pedidos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_produto INT NOT NULL,
    id_estado INT NOT NULL,
    quantidade INT NOT NULL DEFAULT 1,
    data_pedido DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_pedido_cliente
        FOREIGN KEY (id_cliente)
        REFERENCES Clientes(id),

    CONSTRAINT fk_pedido_produto
        FOREIGN KEY (id_produto)
        REFERENCES Produtos(id),
        
	CONSTRAINT fk_pedido_estado
		FOREIGN KEY (id_estado)
		REFERENCES Estado(id)
);

-- Criação da tabela: Estado
CREATE TABLE Estado (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    sigla VARCHAR(2) NOT NULL
);

INSERT INTO abcdef_aula.Cliente
(nome, email, telefone, cpf, endereco, cidade, estado)
VALUES('João Silva', 'joao@gmail.com', '5199986554', '12345678910', 'Rua Marechal Deodoro, 99', 'Santa Cruz do Sul', 'RS');
