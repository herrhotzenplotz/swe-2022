MCS	?=	mcs

PROG	?=	${SRCS:.cs=.exe}

.PHONY: all clean
all: ${PROG}

${PROG}: ${SRCS}
	${MCS} -out:${PROG} ${SRCS}

clean:
	rm -f ${PROG}
