SUBDIR	=	aufgabe1 \
		aufgabe2a \
		aufgabe2b

.PHONY: all clean ${SUBDIR} ${SUBDIR:=-clean}
all: ${SUBDIR}

${SUBDIR}:
	${MAKE} -C ${@} all

clean: ${SUBDIR:=-clean}

${SUBDIR:=-clean}:
	${MAKE} -C ${@:-clean=} clean
