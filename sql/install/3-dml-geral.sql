USE GerenciadorFrotas
GO

INSERT INTO tblUsuario (
    login, 
    nome,  
    email, 
    senha, 
    ativo
) VALUES (
    '1',
    '1',
    'admin@admin',
    'c4ca4238a0b923820dcc509a6f75849b', -- 1
    1
)

INSERT INTO tblSexo (
    descricao
) VALUES (
    'TESTE'
)

INSERT INTO tblStatus (
    descricao
) VALUES (
    'TESTE'
)