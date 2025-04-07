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
    internal class Program
    {
        static void Main(string[] args)
        {
                   int orderId = 1;
                int orderStatus = 1;
                OrderStatus status = OrderStatus.New;

              
                void ChangeStatus(OrderStatus newStatus)
                {
                   

                    
                    status = newStatus;
                    Console.WriteLine($"Заказ {orderId} переведён в статус: {status}");
                }

           
                ChangeStatus(OrderStatus.Processing);
                ChangeStatus(OrderStatus.Shipped);
                ChangeStatus(OrderStatus.Delivered);
                ChangeStatus(OrderStatus.Cancelled);
                ChangeStatus(OrderStatus.New); 
            }
        }
    }
}

