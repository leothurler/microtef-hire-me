   M S B A M L   `   `   `  ����L  HCrazyDragonClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CrazyDragonClientCrazyDragonClient  5   	   ,    &CrazyDragonClient.NewTransactionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CrazyDragonClient     5   	     � Title$  Nova Transação��5   	   $	��350��6    $	��525��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ lbAmount��5
      $��Valor��6"   $
��Left=�62   $��	33,20,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ lbType��5      $
��Tipo��6    $
��Left=�6/   $��	33,51,0,0q�6J   $	��Top=�6]   �� 5   
   -   5        $ lbNumber��5      $��Parcelas��6"   $
��Left=�65   $��	33,82,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ 
lbInfoCard��5      $��Informações do cartão��6$   $
��Left=�6D   $��
33,113,0,0q�6_   $	��Top=�6s   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $��60��6@   $��
33,139,0,0q�6L   
���   �$	��Top=�6o   $	��466��6�   �� 5   
   -   5        $ lbCardNumber��5      $��Número��6&   $
��Left=�67   $��
41,154,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ lbCardPassword��5      $��Password��6(   $
��Left=�6;   $��308,154,0,0q�6V   $	��Top=�6k   �� 5   
   -   5         ��Name$ 	txtAmount��5      $
��Left=�6%   $��23��6@   $��
103,20,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��115��6�   �� 5   
   -   5         ��Name$ cbType��5      $
��Left=�6#   $��23��6>   $��
103,54,0,0q�6J   $	��Top=�6^   $	��115��6v   .@�5      �� $��Crédito��6   $
��Left=�6.   $	��113��6I   �� 5      $��Débito��6   $
��Left=�6,   $	��113��6G   5      �� 5   
   -	   5        $ 	txtNumber��5      $
��Left=�6%   $��23��6@   $��
103,85,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��115��6�   �� 5   
   -
   5        $ txtCardNumber��5      $
��Left=�6)   $��23��6D   $��142,154,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��142��6�   G� 5   
   -   5         G�Name$ txtCardPassword��5      $
��Left=�6/   $��373,154,0,0q�6J   $	��Top=�6_   $	��113��6w   $��23��6�   �� 5   
   -   5         ��Name$ btnMakeTransaction��5      $��Realizar Transação��6-   $
��Left=�6J   $��103,242,0,0q�6e   $	��Top=�6z   $	��103��6�   6�   �� 5   
   -   5        $ btnBack��5      $��Voltar��6"   $
��Left=�63   $��329,242,0,0q�6N   $	��Top=�6c   $	��103��6{   6�   5      5      