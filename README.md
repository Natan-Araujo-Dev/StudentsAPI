# 🎓 StudentsAPI

Uma API simples para gerenciar estudantes.

---

## 🚀 Endpoints

### 📋 Listar todos os alunos  
**GET** `/Students-API/Students`  
Retorna a lista completa de alunos.  

---

### 🔍 Obter aluno por ID  
**GET** `/Students-API/Students/:id`  
Retorna os dados do aluno correspondente ao `id` informado na URL.  

---

### ➕ Criar novo aluno  
**POST** `/Students-API/Students`  
Cria um novo aluno no sistema.  

**Body esperado (JSON):**
```json
{
  "name": "João Silva",
  "grade": 20,
}
