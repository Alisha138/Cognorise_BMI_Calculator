body {
    font-family: Arial, sans-serif;
    background-color: #201e1e;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}

.container {
    background: rgba(0, 0, 0, 0.582);
    padding: 25px;
    border-radius: 10px;
    box-shadow: 20px 0px 15px rgba(9, 2, 58, 0.9),
                0px 20px 15px rgba(9, 2, 58,0.9),
                -20px 0px 15px rgba(9, 2, 58,0.9),
                0px -20px 15px rgba(9, 2, 58,0.9);
    width: 20%;
}

h1 {
    text-align: center;
    color: rgb(58, 58, 236);
}

.input-group {
    margin: 15px 0;
}

label {
    display: block;
    margin-bottom: 8px;
    color: rgb(12, 139, 197);
}

input {
    width: 100%;
    padding: 8px 10px;
    box-sizing: border-box;
    font-size: 15px;
    background-color: rgba(192, 192, 192, 0.623);
    border: none;
    border-radius: 2px;
    cursor: context-menu;
}

button {
    width: 100%;
    padding: 15px;
    font-size: 17px;
    background-color: rgb(9, 2, 58);
    color: white;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    margin-top: 5px;
}

button:hover {
    background-color: rgb(6, 2, 37);
}

#result {
    margin-top: 20px;
    text-align: center;
    font-size: 18px;
    color: rgba(255, 255, 255, 0.795);
}
@media (max-width: 900px) and (min-width: 450px) {
    .container{
        width: 250px;
    }
}
@media (max-width: 450px) {
    .container{
        width: 220px;
    }
    h1{
        font-size: 25px; 
    }
}
