   M S B A M L   `   `   `  ����L  HCrazyDragonClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CrazyDragonClientCrazyDragonClient  5   	   )    #CrazyDragonClient.ConsultCardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CrazyDragonClient     5   	     � Title$  Transações Realizadas��5   	   $	��350��6'   $	��525��64   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Cartões cadastrados��6   $
��Left=�6=   $��
128,38,0,0q�6X   $	��Top=�6l   $��22(�6�   �� 5   
   -   5         ��Name$ 
lvCardData��5      $
��Left=�6'   $	��179��6B   $��	10,90,0,0q�6O   $	��Top=�6b   $	��497��6z    �� View 5      �� 5      .P�5      �� $
��Nome��6%    �� Width$ 75��63    �� DisplayMemberBinding 6>   �� *
cardName+�� 5      $��Numero��6%   $ 75��65    6A   �� *
cardNumber+�� 5      $��Data Exp��6%   $	 105��67    6C   �� *cardExpDate+�� 5      $��Saldo��6%   $ 75��64    6?   �� *cardBalance+�� 5      $��Bandeira��6%   $ 75��67    6B   �� *	cardBrand+�� 5      $
��Tipo��6%   $ 75��63    6>   �� *
cardType+5      5      �� 5   
   -   5         ��Name$ btnBack��5      $��Voltar��6"   $
��Left=�63   $��383,289,0,0q�6N   $	��Top=�6c   $��75��6{   6�   5      5      