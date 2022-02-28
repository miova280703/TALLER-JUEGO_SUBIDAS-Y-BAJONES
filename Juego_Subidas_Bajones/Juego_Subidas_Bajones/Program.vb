Imports System

Module Program
    'DECLARACION DE VARIABLES GLOBALES QUE SE UTILIZARAN EN EL JUEGO
    '-VARIABLE DADO DONDE SE ALMACENARA EL VALOR DEL DADO EN CADA TURNO
    Dim dado As Integer = 0
    '-VARIABLE OPCION DONDE SE ALMACENA LA SELECCION DEL JUGADOR
    Dim opcion As Integer = 0
    '-VARIABLE QUE GUARDA LA CANTIDAD DE JUGADORES QUE JUGARAN
    Dim cantidad_jugadores As Integer = 0
    '-VARIABLE QUE GUARDA LA CANTIDAD DE SUBIDAS EN EL JUEGO
    Dim cantidad_subidas As Integer = 0
    '-VARIABLE QUE GUARDA LA CANTIDAD DE BAJADAS EN EL JUEGO
    Dim cantidad_bajadas As Integer = 0
    '-VARIABLE QUE GUARDA LA POSICION X DE LAS SUBIDAS Y BAJADAS
    Dim x_subidas_bajadas As Integer = 0
    '-VARIABLE QUE GUARDA LA POSICION Y DE LAS SUBIDAS Y BAJADAS
    Dim y_subidas_bajadas As Integer = 0
    '-VARIABLE QUE GUARDA LA NUEVA POSICION GENERADA POR LAS SUBIDAS Y BAJADAS
    Dim dado_subidas_bajadas As Integer = 0

    'DECLARACION DE VECTORES Y MATRICES QUE SE UTILIZARAN EN EL JUEGO
    '-DECLARACION DE LA MATRIZ QUE SERA EL TABLERO DEL JUEGO QUE EL JUGADOR PODRA VER
    '-SE QUIERE QUE EL TABLERO SEA DE 5X8
    '-POR LO TANTO LAS DIMENSIONES REALES DE LA MATRIZ SON 4X7
    Dim tablero_juego(4, 7) As String
    '-DECLARACION DE LA MATRIZ LOGICA EN LA QUE SE REALIZAN TODAS LAS VALIDACIONES
    '-DEL JUEGO Y QUE SE MOSTRARAN EN EL OTRO TABLERO
    Dim tablero_logico(4, 7) As String
    '-DECLARACION DEL VECTOR PARA GUARDAR LOS JUGADORES
    Dim jugadores(3) As String
    '-DECLARACION DEL VECTOR QUE GUARDA LA POSICION ACTUAL DEL JUGADOR EN EL TABLERO
    Dim posiciones(3) As Integer

    'METODO PRINCIPAL QUE EJECUTA LA APLICACION
    Sub Main(args As String())
        'SE IMPRIME EN CONSOLA EL MENSAJE DE BIENVENIDA
        Console.WriteLine("#####################################")
        Console.WriteLine("#     JUEGO SUBIDAS Y BAJONES       #")
        Console.WriteLine("#####################################")

        'SE LLAMA A EJECUTAR EL METODO DE MENU PRINCIPAL
        'PARA COMENZAR CON TODA LA LOGICA DEL JUEGO
        Ejecucion_Menu_Principal()

    End Sub

    'SE CREA UN METODO QUE IMPRIME EN CONSOLA LOS MENSAJES DEL MENU PRINCIPAL
    Sub Menu_Principal_Texto()
        Console.WriteLine("*************************************")
        Console.WriteLine("********   MENU PRINCIPAL    ********")
        Console.WriteLine("*************************************")
        Console.WriteLine("*    1. Dificultad del juego        *")
        Console.WriteLine("*    2. Parametros iniciales        *")
        Console.WriteLine("*    3. Iniciar el juego            *")
        Console.WriteLine("*    4. Salir del juego             *")
        Console.WriteLine("*************************************")
    End Sub

    'SE CREA UN METODO QUE IMPRIME EN CONSOLA LOS MENSAJES DEL MENU DE PARAMETROS INICIALES
    Sub Menu_Parametros_Texto()
        Console.WriteLine("*************************************")
        Console.WriteLine("********   MENU PARAMETROS   ********")
        Console.WriteLine("*************************************")
        Console.WriteLine("*    1. Jugadores                   *")
        Console.WriteLine("*    2. Subidas y Bajones           *")
        Console.WriteLine("*    3. Regresar al menu principal  *")
        Console.WriteLine("*************************************")
    End Sub

    'SE CREA UN METODO QUE IMPRIME EN CONSOLA LOS MENSAJES DEL MENU DIFICULTAD
    Sub Menu_Dificultad_Texto()
        Console.WriteLine("*************************************")
        Console.WriteLine("********   MENU DIFICULTAD   ********")
        Console.WriteLine("*************************************")
        Console.WriteLine("*    1. Facil                       *")
        Console.WriteLine("*    2. Regresar al menu principal  *")
        Console.WriteLine("*************************************")
    End Sub

    'SE CREA UN METODO PARA INICIAR LA EJECUCION DEL MENU PRINCIPAL
    Sub Ejecucion_Menu_Principal()
        'SE EJECUTA HASTA QUE EL USUARIO INGRESE 3 PARA TERMINAR EL JUEGO
        While True
            'SE LLAMA AL METODO DONDE SE IMPRIME LOS MENSAJES DEL MENU
            Menu_Principal_Texto()
            'SE IMPRIME MENSAJE PARA QUE EL JUGADOR INGRESE SU OPCION
            Console.WriteLine("Ingrese opcion...")
            'SE ESTABLECE QUE LA VARIABLE FUNCION SEA 0 PARA QUE ENTRE AL CICLO WHILE
            opcion = 0
            '-SE GUARDA LA OPCION QUE INGRESO EL JUGADOR
            opcion = CInt(Console.ReadLine())
            '-SE VERIFICA QUE LA OPCION INGRESADA ES 1
            If opcion = 1 Then
                '-SE EJECUTA LA DIFICULTAD
                Ejecucion_Menu_Dificultad()
                '-SE VERIFICA QUE LA OPCION INGRESADA ES 2
            ElseIf opcion = 2 Then
                '-SE EJECUTA LOS PARAMETROS INCIALES
                Ejecucion_Menu_Parametros()
                '-SE TERMINA EL CICLO
                End
                '-SE VERIFICA QUE LA OPCION INGRESADA ES 3
            ElseIf opcion = 3 Then
                '-SE EJECUTA EL JUEGO
                'Creando_Subidas()
                Ejecucion_Juego()
                '-SE TERMINA EL CICLO
                End
            ElseIf opcion = 4 Then
                End
            Else
                opcion = 0
            End If
        End While
    End Sub

    'SE CREA UN METODO PARA LA EJECUCION DE LA DIFICULTAD DEL JUEGO
    Sub Ejecucion_Menu_Dificultad()
        '-CICLO QUE SE EJECUTA SIEMPRE
        While True
            '-SE LLAMA AL METODO PARA QUE IMPRIMA EL TEXTO DE ESTE MENU
            Menu_Dificultad_Texto()
            '-SE SOLICITA AL USUARIO QUE INGRESE SU OPCION
            Console.WriteLine("Ingrese opcion...")
            '-SE GUARDA LA OPCION EN LA VARIABLE
            opcion = CInt(Console.ReadLine())
            '-SE VALIDA SI LA OPCION ES 1
            If opcion = 1 Then
                '-SE IMPRIME LA INFORMACION SOBRE LA DIFICULTAD
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                Console.WriteLine("$$$$$$$$   DIFICULTAD FACIL   $$$$$$$")
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                Console.WriteLine("$    DIMENSION TABLERO              $")
                Console.WriteLine("$        5X8                        $")
                Console.WriteLine("$    JUGADORES                      $")
                Console.WriteLine("$        2-3                        $")
                Console.WriteLine("$    SUBIDAS Y BAJONES              $")
                Console.WriteLine("$        SUBIDAS: 5-10              $")
                Console.WriteLine("$        BAJONES: 5-10              $")
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
            ElseIf opcion = 2 Then
                '-SE REGRESA AL MENU PRINCIPAL
                Ejecucion_Menu_Principal()
                End
            Else
                opcion = 0
            End If
        End While
    End Sub

    'SE CREA UN METODO PARA LA EJEJCUCION DEL MENU DE LOS PARAMETROS INICIALES
    Sub Ejecucion_Menu_Parametros()
        '-VARIABLE PARA GUARDAR EL SIMBOLO DEL JUGADOR
        Dim simbolo_jugador As String = ""
        While True
            Menu_Parametros_Texto()
            Console.WriteLine("Ingrese opcion...")
            opcion = CInt(Console.ReadLine())
            Select Case opcion
                Case 1 'CANTIDAD DE JUGADORES Y SUS SIMBOLOS
                    Console.WriteLine("Ingrese cantidad de jugadores...")
                    cantidad_jugadores = CInt(Console.ReadLine())
                    For i = 0 To cantidad_jugadores - 1
                        Console.WriteLine("Ingrese simbolo (que no sea + y -) del jugador" & (i + 1) & "...")
                        simbolo_jugador = Console.ReadLine() + " "
                        jugadores(i) = simbolo_jugador
                    Next
                Case 2 'CANTIDAD DE SUBIDAS Y BAJADAS
                    Console.WriteLine("Ingrese cantidad de subidas de 5-10...")
                    cantidad_subidas = CInt(Console.ReadLine())
                    Console.WriteLine("Ingrese cantidad de bajadas de 5-10...")
                    cantidad_bajadas = CInt(Console.ReadLine())
                Case 3 'REGRESAR AL MENU PRINCIPAL
                    Ejecucion_Menu_Principal()
                    End
            End Select
        End While
    End Sub

    'METODO DONDE SE EJECUTA EL JUEGO DE SUBIDAS Y BAJADAS
    Sub Ejecucion_Juego()
        'SE IMPRIME EN CONSOLA LOS MENSAJES QUE EL JUEGO SE HA INICIADO
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++")
        Console.WriteLine("+       EL JUEGO HA COMENZADO       +")
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++")

        'SE LLENA EL TABLERO IDENTIFICANDO CADA CASILLA CON SU NUMERO CORRESPONDIENTE
        'PARA QUE SE VEA COMO UN TABLERO DE UN JUEGO DE MESA
        Llenando_Tablero()

        'SE LLENA EL TABLERO LOGICO PARA LAS VALIDACIONES DE LAS SUBIDAS Y BAJONES
        Llenando_Tablero_Logica()

        'SE IMPRIME EN CONSOLA EL TABLERO PARA QUE EL JUGADOR LO PUEDA VER
        Mostrando_Tablero()

        'SE IMPRIME EN CONSOLA UN SALTO DE LINEA
        Console.WriteLine("")

        'VARIABLE QUE GUARDA LOS TURNOS DE CADA JUGADOR PARA PODER
        'MOSTRARLOS EN LA CONSOLA CON UN MENSAJE
        Dim movimientos As Integer = 0

        'VARIABLE QUE GUARDA EL RESULTADO DE CUANTO SE TIENE QUE MOVER EL JUGADOR
        Dim moverse As Integer = 0

        'SE INICIA UN CICLO WHILE TRUE PARA QUE SE EJECUTE HASTA QUE SE GANE LA PARTIDA
        While True
            'SE INICIA UN FOR QUE RECORRE EL VECTOR DE LOS JUGADORES
            For jugador = 0 To cantidad_jugadores - 1
                'SE IMPRIME EN CONSOLA MENSAJE DEL TURNO DEL JUGADOR A JUGAR
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++")
                Console.WriteLine("+       TURNO" & (movimientos + 1) & " DEL JUGADOR" & (jugador + 1) & " " & jugadores(jugador) & "      +")
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++")

                'SE VERIFICA QUE ES EL PRIMER TURNO PARA
                'COLOCAR AL JUGADOR AL INICIO DEL TABLERO
                If movimientos = 0 Then
                    'SE COLOCA AL JUGADOR EN LA POSICION 01 DEL TABLERO
                    'PERO EN LA MATRIZ ES EN LA POSICION 4,0
                    tablero_juego(4, 0) = jugadores(jugador)

                    'SE IMPRIME EN CONSOLA EL TABLERO PARA QUE EL JUGADOR VEA SU POSICION
                    Mostrando_Tablero()

                    'SE IMPRIME UN SALTO DE LINEA
                    Console.WriteLine("")

                    'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
                    Randomize()

                    'CALCULO DEL RANDOM DEL DADO, PARA QUE SOLO OBTENER VALORES DE 1-6
                    dado = CInt(Int((6 * Rnd()) + 1))

                    'SE IMPRIME EN CONSOLA EL RESULTADO AL "LANZAR EL DADO"
                    Console.WriteLine("El valor del dado es: " & dado)

                    'SE REALIZA EL CALCULO DE CUANTAS POSICIONES DE MOVERA EL JUGADOR EN EL TABLERO
                    moverse = dado + 1

                    'SE GUARA EN EL VECTOR DE POSICIONES,
                    'EL RESULTADO EN DONDE EL JUGADOR SE MOVERA EN EL TABLERO
                    posiciones(jugador) = moverse

                    'SE EJECUTA EL METODO PARA CAMBIAR LA POSICION DEL JUGADOR EN EL TABLERO
                    Cambiando_Posicion_Tablero(moverse, jugadores(jugador), jugador, 1)

                    'SE IMPRIME EL TABLERO EN CONSOLA PARA QUE EL JUGADOR VEA SU NUEVA POSICION
                    Mostrando_Tablero()

                    'SE IMPRIME UN MENSAJE EN CONSOLA PARA QUE EL JUGADOR PRESIONE UNA TECLA PARA CONTINUAR CON EL JUEGO
                    Console.WriteLine("Ingrese una tecla para continuar con el juego...")

                    'SE LEE LA TECLA PRESIONADA PARA CONTINUAR CON EL JUEGO 
                    Dim pausa As String = Console.ReadLine()

                    'SI NO ES EL PRIMER TURNO SE EJECUTA ESTE ELSE
                Else
                    'SE IMPRIME EN CONSOLA EL TABLERO PARA QUE EL JUGADOR PUEDA VERLO
                    Mostrando_Tablero()

                    'SE IMPRIME UN SALTO DE LINEA EN CONSOLA
                    Console.WriteLine("")

                    'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
                    Randomize()

                    'CALCULO DEL RANDOM DEL DADO, PARA QUE SOLO OBTENER VALORES DE 1-6
                    dado = CInt(Int((6 * Rnd()) + 1))

                    'SE IMPRIME EN CONSOLA UN MENSAJE CON EL RESULTADO AL "LANZAR EL DADO"
                    Console.WriteLine("El valor del dado es: " & dado)

                    'SE REALIZA EL CALCULO DE LAS POSICIONES QUE EL JUGADOR SE MOVERÁ
                    moverse = dado + posiciones(jugador)

                    'SE VERIFICA QUE SI LA POSICION A LA QUE SE MOVERA EL JUGADOR ES MAYOR O IGUAL A 40
                    'EL JUEGO HA TERMONIADO
                    If moverse >= 40 Then
                        'SE IMPRIME EN CONSOLA QUE EL JUEGO HA FINALIZADO
                        'JUNTO CON EL JUGADOR GANADOR
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++")
                        Console.WriteLine("+       EL JUEGO HA TERMINADO       +")
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++")
                        Console.WriteLine("+ EL GANADOR ES EL JUGADOR" & (jugador + 1) & " " & jugadores(jugador) & " +")
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++")

                        'SE EJECUTA EL METODO DEL MENU PRINCIPAL
                        Ejecucion_Menu_Principal()

                        'SE TERMINA EL METODO, EL WHILE Y EL FOR
                        Exit Sub

                        'SI NO SE CUMPLE LA CONDICION SE EJECUTA EL SIGUIENTE ELSE
                    Else
                        'SE CAMBIA LA POSICION EN EL TABLERO
                        Cambiando_Posicion_Tablero(moverse, jugadores(jugador), jugador, posiciones(jugador))

                        'SE IMPRIME EN CONSOLA EL TABLERO
                        Mostrando_Tablero()

                        'SE LE PIDE AL JUGADOR QUE INGRESE UNA TECLA PARA SEGUIR CON EL JUEGO
                        Console.WriteLine("Ingrese una tecla para continuar con el juego...")

                        'SE LEE LA TECLA PRESIONADA
                        Dim pausa As String = Console.ReadLine()
                    End If
                End If
            Next
            'If movimientos = 2 Then
            '    End
            'End If

            If tablero_juego(0, 7).Equals("$$") Then
                movimientos = movimientos + 1
            Else
                Ejecucion_Menu_Principal()
                Exit Sub
            End If

        End While
    End Sub

    'METODO PARA CAMBIAR LA POSICION DEL JUGADOR EN EL TABLERO
    'ESTE METODO RECIBE COMO PARAMETROS:
    '-EL VALOR DEL A LA CASILLA EN LA QUE SE MOVERA EL JUGADOR
    '-EL SIMBOLO QUE IDENTIFICA AL JUGADOR
    '-EL VALOR DE LA CASILLA EN LA QUE SE ENCUENTRA EL JUGADOR ANTES DE MOVERSE
    Sub Cambiando_Posicion_Tablero(valor_movimiento As Integer, jugador As String, numero_jugador As Integer, posicion_actual As Integer)
        'SE CONVIERTE A TEXTO EL VALOR DE LA CASILLA A LA QUE SE MOVERA EL JUGADOR
        Dim valor As String = agregando_cero(valor_movimiento)

        'SE CONVIERTE A TEXTO EL VALOR DE LA CASILLA ACTUAL
        Dim actual As String = agregando_cero(posicion_actual)

        'SE RECORRE LA MATRIZ PARA COLOCAR EL NUMERO DE LA CASILLA
        'Y BORRAR AL JUGADOR EN LA POSICION ACTUAL
        For x = 0 To 4
            For y = 0 To 7
                'SE VERIFICA QUE LA POSICION DE LA MATRIZ SEA IGUAL AL SIMBOLO DEL JUGADOR
                If tablero_juego(x, y).Equals(jugador) Then
                    'SE COLOCA EL NUMERO DE LA CASILLA BORRANDO EL SIMBOLO DEL JUGADOR
                    tablero_juego(x, y) = actual
                End If
            Next
        Next

        'SE RECORRE LA MATRIZ PARA CAMBIAR AL JUGADOR DE POSICION
        For x = 0 To 4
            For y = 0 To 7
                'SE VERIFICA QUE LA POSICION DE LA MATRIZ SEA IGUAL AL VALOR AL QUE SE VA A MOVER EL JUGADOR
                If tablero_juego(x, y).Equals(valor) Then
                    'SE VERIFICA QUE EN ESA CASILLA NO SEA UNA CASILLA ESPECIAL
                    'ES DECIR UNA CASILLA CON SUBIDAS O BAJONES
                    If tablero_logico(x, y).Equals("@") Then
                        'SE COLOCA EL SIMBOLO DEL JUGADOR EN LA CASILLA CORRESPONDIENTE
                        tablero_juego(x, y) = jugador

                        'SE GUARDA LA POSICION DEL JUGADOR EN EL VECTOR
                        posiciones(numero_jugador) = valor_movimiento
                    Else 'DE LO CONTRARIO ES UNA CASILLA ESPECIAL

                        'SE VERIFICA SI ES UNA SUBIDA O UNA BAJADA
                        If tablero_logico(x, y).Equals("+") Then
                            'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
                            Randomize()

                            'CALCULO DEL RANDOM DEL DADO, PARA QUE SOLO OBTENER VALORES DE 1-6
                            dado_subidas_bajadas = CInt(Int((6 * Rnd()) + 1))

                            'VARIABLE PARA LA NUEVA POSICION DEL JUGADOR EN EL TABLERO
                            Dim cambio As Integer = valor_movimiento + dado_subidas_bajadas

                            'MENSAJE DICIENDO QUE SE ENCONTRO CON UNA SUBIDA Y CUANTO AVANZA
                            Console.WriteLine("Hubo una subida de: " & dado_subidas_bajadas & ", avanza a la casilla: " & cambio.ToString())

                            'SE REESCRIBE EL VALOR DE LA VARIABLE VALOR PARA PODER BUSCAR LA CASILLA
                            valor = agregando_cero(cambio)

                            'SE REESCRIBE EL VALOR DE VALOR DE MOVIMIENTO PARA
                            'REALIZAR EL CAMBIO EN LA CASILLA CORRECTA
                            valor_movimiento = cambio

                            'SE REINICIA LAS VARIABLES DE LOS CICLOS FOR
                            'PARA VOLVER A REALIZAR LA VALIDACION
                            y = 0
                            x = 0

                        ElseIf tablero_logico(x, y).Equals("-") Then
                            'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
                            Randomize()

                            'CALCULO DEL RANDOM DEL DADO, PARA QUE SOLO OBTENER VALORES DE 1-6
                            dado_subidas_bajadas = CInt(Int((6 * Rnd()) + 1))

                            'VARIABLE PARA LA NUEVA POSICION DEL JUGADOR EN EL TABLERO
                            Dim cambio As Integer = valor_movimiento - dado_subidas_bajadas

                            'MENSAJE DICIENDO QUE SE ENCONTRO CON UNA SUBIDA Y CUANTO AVANZA
                            Console.WriteLine("Hubo una bajada de: " & dado_subidas_bajadas & ", retrocede a la casilla: " & cambio.ToString())

                            'SE REESCRIBE EL VALOR DE LA VARIABLE VALOR PARA PODER BUSCAR LA CASILLA
                            valor = agregando_cero(cambio)

                            'SE REESCRIBE EL VALOR DE VALOR DE MOVIMIENTO PARA
                            'REALIZAR EL CAMBIO EN LA CASILLA CORRECTA
                            valor_movimiento = cambio

                            'SE REINICIA LAS VARIABLES DE LOS CICLOS FOR
                            'PARA VOLVER A REALIZAR LA VALIDACION
                            y = 0
                            x = 0
                        End If
                    End If

                End If
            Next
        Next
    End Sub

    'FUNCION QUE AGREGA UN 0 ANTES DE LOS NUMEROS DEL 1-9
    'Y DEVUELVE EL NUMERO EN TEXTO
    Function agregando_cero(val As Integer)
        If val = 1 Then
            Return "01"
        ElseIf val = 2 Then
            Return "02"
        ElseIf val = 3 Then
            Return "03"
        ElseIf val = 4 Then
            Return "04"
        ElseIf val = 5 Then
            Return "05"
        ElseIf val = 6 Then
            Return "06"
        ElseIf val = 7 Then
            Return "07"
        ElseIf val = 8 Then
            Return "08"
        ElseIf val = 9 Then
            Return "09"
        End If
        Return val.ToString()
    End Function

    'METODO QUE LLENA LA MATRIZ CON LO NUMEROS DE LAS CASILLAS DEL TABLERO
    Sub Llenando_Tablero()
        'SE TIENE UNA VARIABLE CONTADOR QUE TIENE COMO RESULTADO UN 40
        'QUE SON EL TOTAL DE CASILLAS A LLENAR.
        'PARA LLENAR LAS CASILLAS EN LA MATRIZ SE HACE DE MANERA DESCENDENTE
        Dim contador As Integer = 5 * 8

        'VARIABLE QUE INDICA EN QUE FILA DE LA MATRIZ SE ENCUENTA
        'SI EN UNA PAR O UNA IMPAR
        Dim posicion As Integer = 0

        'SE COMIENZA A RECORRER LA MATRIZ, SE EMPIEZA POR LAS FILAS
        For x = 0 To 4
            'SE VERIFIA SI SE ENCUENTA EN UNA FILA IMPAR
            If posicion = 1 Then
                'CON ESTE FOR SE RECORRE LAS COLUMNAS
                For y = 0 To 7
                    'SE VERIFICA SI EL CONTADOR ESTA EN EL NUMERO 9 PARA AGREGARLE UN 0
                    If contador = 9 Then
                        'SE COLOCA EL NUMERO DE LA CASILLA EN LA MATRIZ
                        tablero_juego(x, y) = "0" & contador.ToString()
                        'SE RESTA UNA POSICION AL CONTADOR
                        contador = contador - 1
                    Else 'DE CASO CONTARIO
                        'SE COLOCA EL NUMERO DE LA CASILLA EN LA MATRIZ
                        tablero_juego(x, y) = contador.ToString()
                        'SE RESTA UNA POSICION AL CONTADOR
                        contador = contador - 1
                    End If
                Next
                'SE COLOCA EN 0 LA POSICION PARA VALIDAR QUE LA OTRA FILA ES PAR
                posicion = 0

                'SE VALIDA QUE LA FILA ES PAR
            ElseIf posicion = 0 Then
                'CON ESTA VARIABLE SE RECORRE LAS COLUMNAS Y
                'SE INICIALIZA CON EL TOTAL DE COLUMNAS QUE HAY
                Dim ii As Integer = 7

                'SE CREA UN WHILE PARA RECORRER LAS COLUMNAS DE LA ULTIMA A LA PRIMERA
                'ESTE WHILE SE EJECUTARA HASTA QUE LA VARIABLE SEA MAYOR O IGUAL QUE CERO
                While ii >= 0
                    'SE VERIFICA QUE EL CONTADOR SEA IGUAL A 40
                    If contador = 40 Then
                        'EN EL TABLERO SE AGREGA EL SIMBOLO DE FIN
                        tablero_juego(x, ii) = "$$"
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                        'DE LO CONTARIO SE VERIFICA SI ES UN NUMERO DEL 1-8 PARA AGREGARLE 0
                    ElseIf contador = 1 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO EL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 2 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 3 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 4 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 5 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 6 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 7 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    ElseIf contador = 8 Then
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = "0" & contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    Else 'DE CASO CONTRARIO DE QUE NO SEA NINGUNO DE ESOS NUMEROS
                        'SE AGREGA LA CASILLA A LA MATRIZ
                        tablero_juego(x, ii) = contador.ToString()
                        'SE RESTA UNO AL CONTADOR
                        contador = contador - 1
                    End If
                    'SE RESTA UNO AL CONTADOR DE LAS COLUMNAS PARA SEGUIR LLENANDO CADA COLUMNA
                    ii = ii - 1
                End While
                'SE COLOCA QUE ES UNA POSICION 1 PARA GARANTIZAR QUE LA SIGUIENTE FILA ES UNA FILA IMPAR
                posicion = 1
            End If
        Next
    End Sub

    'ESTE METODO LLENA EL TABLERO LOGIO CON EL SIMBOLO DE "@"
    Sub Llenando_Tablero_Logica()
        'SE RECORRE LA MATRIZ TANTO FILAS COMO COLUMNAS
        For x = 0 To 4
            For y = 0 To 7
                'A CADA POSICION DE LA MATRIZ SE LE AGREGA EL SIMBOLO DE "@"
                tablero_logico(x, y) = "@"
            Next
        Next
        Creando_Subidas()
        Creando_Bajones()
    End Sub

    'METODO PARA CREAR LAS SUBIDAS EN EL TABLERO LOGICO
    Sub Creando_Subidas()
        For i = 0 To cantidad_subidas - 1
            'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
            Randomize()

            'CALCULO DE LAS POSICIONES PARA LAS SUBIDAS
            x_subidas_bajadas = CInt(Int((4 * Rnd()) + 1))
            y_subidas_bajadas = CInt(Int((6 * Rnd()) + 1))

            If tablero_logico(x_subidas_bajadas, y_subidas_bajadas).Equals("@") Then
                tablero_logico(x_subidas_bajadas, y_subidas_bajadas) = "+"
            Else
                i = i - 1
            End If
        Next
    End Sub

    'METODO PARA CREAR LAS BAJONES EN EL TABLERO LOGICO
    Sub Creando_Bajones()
        For i = 0 To cantidad_subidas - 1
            'SE INICIALIZA EL METODO RANDOM DE VB PARA EL DADO
            Randomize()

            'CALCULO DE LAS POSICIONES PARA LAS SUBIDAS
            x_subidas_bajadas = CInt(Int((4 * Rnd()) + 1))
            y_subidas_bajadas = CInt(Int((6 * Rnd()) + 1))

            If tablero_logico(x_subidas_bajadas, y_subidas_bajadas).Equals("@") Then
                tablero_logico(x_subidas_bajadas, y_subidas_bajadas) = "-"
            Else
                i = i - 1
            End If
        Next
    End Sub

    'METODO PARA IMPRIMIR EL TABLERO EN CONSOLA
    Sub Mostrando_Tablero()
        'SE COMIENZAN A RECORRER LAS FILAS DE LA MATRIZ
        For x = 0 To tablero_juego.GetLength(0) - 1
            'SE IMPRIME EL DELIMITADOR IZQUIERDO
            Console.Write("|")
            'SE RECORRE LAS COLUMNAS
            For y = 0 To tablero_juego.GetLength(1) - 1
                'SE IMPRIME LOS VALORES DE LA MATRIZ EN ESA POSICION
                Console.Write(tablero_juego(x, y))
                'SI NO SE HA LLEGAGO A LA ULTIMA COLUMNA
                If y < tablero_juego.GetLength(1) - 1 Then
                    'SE IMPRIME UN ESPACIO
                    Console.Write(" ")
                End If
            Next
            'SE IMPRIME EL DELIMITADOR DERECHO
            Console.WriteLine("|")
        Next
    End Sub


End Module
