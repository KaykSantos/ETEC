<?php
    echo '<h2> Valores digitados: ' .$_POST['medida1']. ', ' .$_POST['medida2']. ' e ' .$_POST['medida3']. '.</h2>';

    echo '<div></div>';

    echo '<script>';
    echo'if(' .$_POST['medida1']. '> (' .$_POST['medida2']. '+' .$_POST['medida3']. ') ||';
    echo $_POST['medida2']. '> (' .$_POST['medida1']. '+' .$_POST['medida3']. ') ||';
    echo $_POST['medida3']. '> (' .$_POST['medida1']. '+' .$_POST['medida2']. '))';
    echo '{ <br><br>' ;
        echo 'if(' .$_POST['medida1']. '==' . $_POST['medida2']. '&&' .$_POST['medida2']. '==' .$_POST['medida3']. '){';
        echo 'Os valores são válidos. O triangulo formado é um triângulo equilatero. }';

        echo 'else if(' .$_POST['medida1']. '!=' . $_POST['medida2']. '&&' .$_POST['medida2']. '!=' .$_POST['medida3']. '&&' .$_POST['medida1']. '!=' .$_POST['medida3']. '){';
        echo 'Os valores são válidos. O triangulo formado é um triângulo escaleno. }';

        echo 'else(Os valores são válidos. O triângulo formado é um triângulo isosceles)';
    echo '}'; 
    echo 'else(Os valores não formam um triângulo!)';
    echo'</script>';

?>