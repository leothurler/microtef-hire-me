   M S B A M L   `   `   `  ����L  HCrazyDragonClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CrazyDragonClientCrazyDragonClient  5   	   0    *CrazyDragonClient.ConsultTransactionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CrazyDragonClient     5   	     � Title$  Transações Realizadas��5   	   $	��350��6'   $	��525��64   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Transações Realizadas��6   $
��Left=�6?   $��
128,38,0,0q�6Z   $	��Top=�6n   $��22(�6�   �� 5   
   -   5         ��Name$ lvTransactionsData��5      $
��Left=�6/   $	��179��6J   $��	10,90,0,0q�6W   $	��Top=�6j   $	��497��6�    �� View 5      �� 5      .P�5      �� $��Valor��6%    �� Width$ 71��64    �� DisplayMemberBinding 6?   �� *amount+�� 5      $
��Tipo��6%   $ 71��63    6>   �� *type+�� 5      $��Parcelas��6%   $ 71��67    6B   �� *number+�� 5      $
��Nome��6%   $ 71��63    6>   �� *
cardName+�� 5      $��Numero��6%   $ 71��65    6A   �� *
cardNumber+�� 5      $��Data Exp��6%   $ 71��67    6B   �� *cardExpDate+�� 5      $��Bandeira��6%   $ 71��67    6B   �� *	cardBrand+5      5      �� 5   
   -   5         ��Name$ btnBack��5      $��Voltar��6"   $
��Left=�63   $��383,289,0,0q�6N   $	��Top=�6c   $��75��6{   6�   5      5      