create or replace function emp_delete (_id character varying)
returns int AS
$$
	begin
		delete from karyawan WHERE id_karyawan = _id;
		if found then
			return 1;
		else
			return 0;
		end if;
	end
$$ language plpgsql
