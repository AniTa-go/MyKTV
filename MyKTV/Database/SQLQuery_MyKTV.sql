--��ѯ���и�����Ϣ
select song_name,singer_name from song_info left join singer_info on song_info.singer_id = singer_info.singer_id
--�������ݵ�����������
insert singer_type values('��½'),('��̨'),('ŷ��'),('�պ�'),('����')
select * from singer_type
--�������ݵ�������Ϣ����
insert singer_info values('��Ρ','1','��','E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\��Դ\singerPhoto\��Ρ.jpg')
						,('Ѧ֮ǫ','1','��','E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\��Դ\singerPhoto\Ѧ��ǫ.jpg')
						,('������','1','Ů','E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\��Դ\singerPhoto\������.jpg')
						,('Avril Ramona Lavigne','3','Ů','E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\��Դ\singerPhoto\Avril Ramona Lavigne .jpg')
select * from singer_info
select * from song_type	
--�������ݵ�������Ϣ����
insert song_info values ('����','YW','2','1','6','E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\��Դ\song\Ѧ֮ǫ - ����.mp3','0')
					   ,('','','','','','','')		
select song_name,singer_name,song_play_count  from 	dbo.singer_info,dbo.song_info where song_info.singer_id = singer_info.singer_id
--��ѯ����Ա�˻���Ϣ
select COUNT(*) from admin_info where admin_name = '' and admin_pwd = ''
--��ѯ�������ͱ�
select * from singer_type
--��ѯȫ��������Ϣ
select s_i.singertype_id,singer_name,singer_sex,singertype_name,singer_photo_url,singer_Describe from singer_info s_i inner join singer_type s_t on s_i.singertype_id = s_t.singertype_id
--�޸ĸ�����Ϣ
update dbo.singer_info set singer_name = '',singertype_id = '',singer_sex = '',singer_photo_url = '',singer_Describe = ''
select singer_name,singertype_id,singer_sex,singer_photo_url,singer_Describe from dbo.singer_info where singer_id = ''
select song_name,songtype_name,song_url,song_play_count from dbo.song_info s_i inner join dbo.song_type s_t on(s_i.songtype_id=s_t.songtype_id)
select * from song_type
insert dbo.song_info values('','','','','','','')
delete song_info where song_id = ''
select song_name,song_ab,song_word_count,songtype_id,song_url,singer_name from dbo.song_info,singer_info where song_id = '' and singer_info.singer_id = song_info.singer_id
UPDATE [MyKTV].[dbo].[song_info]  SET [song_name] = '',[song_ab] ='',[song_word_count] = '',[songtype_id] = '',[singer_id] = '',[song_url] = '' WHERE song_id=''
select singer_name from dbo.singer_info where singer_id =''
select song_name,song_ab,song_word_count,songtype_id,song_url,singer_name from dbo.song_info,singer_info where song_id = '1' and singer_info.singer_id = song_info.singer_id
select singer_name,singer_photo_url from dbo.singer_info
select song.song_name,singer_name,song_play_count from song_info song,singer_info singer where song.singer_id = singer.singer_id and singer.singer_id = ''
select song_url,singer_photo_url,singer_Describe from singer_info s inner join song_info i on s.singer_id = i.singer_id and s.singer_id = ''
select song_url,song_name,song_play_count,singer_name from singer_info,song_info where song_info.singer_id = singer_info.singer_id and singer_info.singer_id = '{0}'
select * from  song_info,singer_info where song_info.singer_id = singer_info.singer_id and song_ab =''
select * from  song_info,singer_info where song_info.singer_id = singer_info.singer_id order by song_play_count desc
select * from song_info where song_url = ''
select * from singer_info where singer_photo_url =''
update singer_info set singer_photo_url = '' where singer_id = ''
update song_info set song_url = '' where song_id = ''
select singer_photo_url from singer_info
select song_url from song_info
select singer_photo_url from singer_info
update singer_info set singer_photo_url = 'E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\MyKTV\MyKTV_\MyKTV_\bin\Debug\singerPhoto\��Ρ.jpg' where singer_id = '19'
update singer_info set singer_photo_url = 'E:\ͬ���ļ���\C#\Winform����Ӧ�ó���\��ҵ��ĿKTV���ϵͳ\MyKTV\MyKTV_\MyKTV_\bin\Debug\Photo\singerPhoto\��Ρ.jpg' where singer_id = '19'
