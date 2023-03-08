     	correct_answer = string(abs(max(triangle.a,max(triangle.b,triangle.c)) - secondMin(triangle.a,triangle.b,triangle.c) - min(triangle.a,min(triangle.b,triangle.c))));   
    	wrong_answer = string(abs(max(triangle.a,max(triangle.b,triangle.c)) - secondMin(triangle.a,triangle.b,triangle.c) - min(triangle.a,min(triangle.b,triangle.c))) + 1 + rand_int(level*3));
        if(rand_int(2) == 0){
        	wrong_answer = string(abs(max(triangle.a,max(triangle.b,triangle.c)) - secondMin(triangle.a,triangle.b,triangle.c) - min(triangle.a,min(triangle.b,triangle.c))) - 1 - rand_int(level*3));    
        }
        if(int(wrong_answer) < 0){
			wrong_answer = string(abs(max(triangle.a,max(triangle.b,triangle.c)) - secondMin(triangle.a,triangle.b,triangle.c) - min(triangle.a,min(triangle.b,triangle.c))) + 1 + rand_int(level*3));
        }