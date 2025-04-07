namespace task_20_03
{
    /*Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечислениеOrderStatus со значениями:
• New (новый)
• Processing (в обработке)
• Shipped (отправлен)
• Delivered (доставлен)
• Cancelled (отменён)
Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён, запретите изменение статуса. Выводите сообщение при каждом изменении статуса (например,
"Заказ переведён в статус: Отправлен"*/

    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    internal class Program
    {
       
      
            static void Main(string[] args)
            {
                int orderId = 1;
                OrderStatus status = OrderStatus.New; 

                // фигурируем изменение статуса
                void ChangeStatus(OrderStatus newStatus)
                {
                    if (status == OrderStatus.Delivered || status == OrderStatus.Cancelled)
                    {
                        Console.WriteLine($"Невозможно сменить статус заказа {orderId}, так как заказ{status}.");
                        return;
                    }

                    // смена статуса 
                    Console.WriteLine($"Заказ {orderId} теперь находится в статусе: {status}");
                }
                ChangeStatus(OrderStatus.Processing);
                ChangeStatus(OrderStatus.Shipped);
                ChangeStatus(OrderStatus.Delivered);
                ChangeStatus(OrderStatus.Cancelled);


            }
           
    }
}



