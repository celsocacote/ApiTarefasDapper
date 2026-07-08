create table if not exists tarefas(
    Id integer primary key autoincrement,
    Descricao text not null,
    IsCompleta integer not null default 0
);