Module Module1

    Sub Main()
        Dim employee_number As String
        Dim pay_rate As Single
        Dim employee_hours As Byte
        Dim weekly_pay As Single

        Console.WriteLine("Enter employee's number: ")
        employee_number = Console.ReadLine()

        Console.WriteLine("Enter number of hours employee worked: ")
        employee_hours = Console.ReadLine()

        Console.WriteLine("Enter employee's hourly pay rate: ")
        pay_rate = Console.ReadLine()

        If employee_hours > 60 And pay_rate > 25.0 Then
            Console.WriteLine($"Employee's hours worked ({employee_hours} hours) and pay rate (${pay_rate} per hour), exceeds maximum allowed (60hours, $25.00)")
        ElseIf employee_hours > 60 Then
            Console.WriteLine($"Employee's hours worked ({employee_hours} hours), exceeds maximum hours (60)")
        ElseIf pay_rate > 25.0 Then
            Console.WriteLine($"Employee's pay rate (${pay_rate} per hour), exceeds the maximum allowed ($25.00)")
        Else
            weekly_pay = employee_hours * pay_rate
            Console.WriteLine($"Employee Number: {employee_number}{vbNewLine}Hours Worked: {employee_hours}{vbNewLine}Hourly rate: ${pay_rate}{vbNewLine}Weekly Pay: ${weekly_pay} ")
        End If

        Console.ReadKey(True)
    End Sub

End Module
