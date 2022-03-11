<?php
    echo '<h2> Valores digitados: ' .$_POST['medida1']. ', ' .$_POST['medida2']. ' e ' .$_POST['medida3']. '.</h2>';

    echo '<script>';

        echo 'if(';
            echo $_POST['medida1']. '> (' .$_POST['medida2']. '+' .$_POST['medida3']. ') ||';
            echo $_POST['medida2']. '> (' .$_POST['medida1']. '+' .$_POST['medida3']. ') ||';
            echo $_POST['medida3']. '> (' .$_POST['medida2']. '+' .$_POST['medida1']. ')';
        echo '){'; 
            echo 'document.getElementById(' .$_POST['saas'].' ).value = "O triângulo é inválido" ';
        echo '}';

        echo 'if(';
            echo $_POST['medida1']. '==' .$_POST['medida2']. '&&' .$_POST['medida2']. '==' .$_POST['medida3']; 
        echo '){'; 
            echo 'document.getElementById(' .$_POST['saas'].' ).value = "O triângulo é equilátero" ';
        echo '}';

        echo 'if(';
            echo '(' .$_POST['medida1']. '==' .$_POST['medida2']. '$$' .$_POST['medida2']. '!=' .$_POST['medida3']. ') ||';
            echo '(' .$_POST['medida2']. '==' .$_POST['medida3']. '$$' .$_POST['medida3']. '!=' .$_POST['medida1']. ') ||';
            echo '(' .$_POST['medida3']. '==' .$_POST['medida1']. '$$' .$_POST['medida1']. '!=' .$_POST['medida2']. ')'; 
        echo '){'; 
            echo 'document.getElementById(' .$_POST['saas'].' ).value = "O triângulo é isósceles" ';
        echo '}';

        echo 'else{'; 
            echo 'document.getElementById(' .$_POST['saas'].' ).value = "O triângulo é escaleno" ';
        echo '}';
    
        echo '<div id="saas" name="saas"> </div>';
        
    echo'</script>';

?>