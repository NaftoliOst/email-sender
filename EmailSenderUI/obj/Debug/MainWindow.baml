   M S B A M L   `   `   `  ����H  DEmailSenderUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EmailSenderUIEmailSenderUI  5   	       EmailSenderUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EmailSenderUI     5   	   $��28(�5   	     � Title$  Email Sender��5	   	   $	��450��6   $	��800��6+   $	��300��67   $	��500��6G   .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Right=�6   $��5q�60   $��0��6;   $��0��6K   To:6]   �� 5   
   -   5         ��Name$ To��5      $��0��6   $��1��6+   $��2q�6;   $��5q�6G   $��2��6R   6h   �� 5   
   $��Right=�6   $��5q�60   $��0��6;   $��1��6K   
Subject:6b   �� 5   
   -   5        $ Subject��5      $��1��6#   $��1��60   $��2q�6@   $��5q�6L   $��2��6W   6m   �� 5   
   $��Right=�6   $��5q�60   $��0��6;   $��2��6K   
Message:6b   �� 5   
   -   5        $
 Body��5       �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�65   $��2��6X   $��1��6e   $��2q�6u   $��5q�6�   $��2��6�   6�   �� 5!   
   $��Right=�6   $��5q�60   $��0��6;   $��3��6K   	Password:6c   G� 5"   
   -   5         G�Name$ Password��5"      $��3��6(   $��1��65   $��2q�6E   $��5q�6Q   $��2��6\   6r   �� 5%   
   -   5         ��Name$
 Send��5%      $��1��62   $��4��6B   $��5q�6O   .��6Z   Send6`   5&      5'      