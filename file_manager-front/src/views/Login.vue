<template>
    <div class="Login-container">
        <div class="row">
            <div class="input-field col s12">
                <input  id="email_address" type="text" class="validate">
                <label for="email_address">Эллектронный адрес</label>
            </div>
            <div class="input-field col s12">
                <input id="password"  type="password" class="validate">
                <label for="password">Пароль</label>
            </div>
            <div class="col s12">
                <a href="#">Забыли пароль?</a>
            </div>
            <div class="rowfooter col s12">
                <label>
                    <input type="checkbox" class="filled-in" />
                    <span>Запонмить</span>
                </label>
                <button>Вход</button>
            </div>
      </div>
    </div>
</template>

<script>

export default {

}

</script>

<style lang="scss">
    .Login-container{
        margin: auto;
        margin-top: 23vh;
        width: 28%;
        height: 43vh;
        box-shadow: 0px 1px 13px rgb(242, 242, 242, 1);
        border-radius: 6%;

        .row{
            padding: 3%;
            padding-top: 4vh;
            .input-field input[type=text]:focus + label {
                margin-left: 1%;
                color: rgb(204, 197, 197);
            }
            .input-field input[type=text]:focus {
                border-bottom: 1px solid #2ba6de;
                box-shadow: none;
            }
            .input-field input[type=password]:focus + label {
                margin-left: 1%;
                color: rgb(204, 197, 197);
            }
            .input-field input[type=password]:focus {
                border-bottom: 1px solid #2ba6de;
                box-shadow: none;
            }
        }

        a{
            float: right;
        }

        .rowfooter{
            margin-top: 5.5vh;
        }

        input[type=checkbox]{
            background-color: silver;
            border: silver;
        }

        button{
            margin-top: -1vh;
            float: right;
            cursor: pointer;
            color: #ffffff;
            background: linear-gradient(to top, #fd4a43, 60%, #e27370);
            border: 2px solid #fa6961;
            height: 4.8vh;
            width: 17%;
            border-radius: 4%;
            font-weight: 500px;
        }

        button:hover{
            background: linear-gradient(to top, #fd4a43, 80%, #e27370);
        }
    }
</style>